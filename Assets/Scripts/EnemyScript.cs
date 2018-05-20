using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int EnemyHealth = 60;
    public GameObject ObjectiveComplete;
    public GameObject TheEnemy;



    void DeductPoints(int DamageAmount){
        EnemyHealth -= DamageAmount;
    }
    void Update(){
        if(EnemyHealth <= 0){
           // TheEnemy.GetComponent<Animation>().Stop("Attacking");
            //TheEnemy.GetComponent<Animation>().Stop("Walking");
            TheEnemy.GetComponent<Animation>().Play("Dying");
            StartCoroutine(Destroyy());
        }
       
    }

    IEnumerator Destroyy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
        ObjectiveComplete.SetActive(true);
    }

}
