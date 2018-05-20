

using UnityEngine;
using System.Collections;

public class ZombieFollow : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 15;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;
    public float dist;
    public Vector3 direction;
    public Transform Player;
    public bool once;


    public GameObject[] Healths;
    public int healthcount = 0;

    float angle = 10;


    public int IsAttacking;
    public GameObject ScreenFlash;
    public AudioSource Hurt01;
    public AudioSource Hurt02;
    public AudioSource Hurt03;
    public int PainSound;


    void Update()
    {
        dist = Vector3.Distance(ThePlayer.transform.position, TheEnemy.transform.position);  
       
   
           
            if (dist < AllowedRange)
            {
                if (Vector3.Angle(ThePlayer.transform.forward, transform.position - ThePlayer.transform.position) < angle)
                {
                    once = false;
                }
                    if (once == false)
                {
                    transform.LookAt(ThePlayer.transform.position);
                    once = true;
                }

                
                EnemySpeed = 0.1f;
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("Walking");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position , EnemySpeed);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("Idle");
                once = false;
            }
        

        if ((AttackTrigger == 1)&&(dist<3))
        {
            if (IsAttacking == 0)
            {
                StartCoroutine(EnemyDamage());
            }
            EnemySpeed = 0;
            TheEnemy.GetComponent<Animation>().Play("Attacking");
        }
    }

    void OnTriggerEnter()
    {
        AttackTrigger = 1;
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }


    IEnumerator EnemyDamage()
    {
        IsAttacking = 1;
        PainSound = Random.Range(1, 4);
        yield return new WaitForSeconds(0.9f);
        ScreenFlash.SetActive(true);
        GlobalHealth.PlayerHealth -= 2;
        Healths[healthcount].SetActive(false);
        healthcount++;
        if (PainSound == 1)
        {
            Hurt01.Play();
        }
        if (PainSound == 2)
        {
            Hurt02.Play();
        }
        if (PainSound == 3)
        {
            Hurt03.Play();
        }
        yield return new WaitForSeconds(0.05f);
        ScreenFlash.SetActive(false);
        yield return new WaitForSeconds(1);
        IsAttacking = 0;

    }



}