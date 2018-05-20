using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGFire : MonoBehaviour {


    
    public GameObject Flash;
    public float Firerate = 10;
    float LastFired;
    // Use this for initialization
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
          if ((Time.time - LastFired) >( 1 / Firerate)) {
                LastFired = Time.time;

                if (GlobalAmmo.CurrentSMGAmmo > 0)
            {
                AudioSource sound = gameObject.GetComponent<AudioSource>();
                sound.Play();
                Flash.SetActive(true);
                GetComponent<Animation>().Play("SMGShot");
                GlobalAmmo.CurrentSMGAmmo -= 1;
                StartCoroutine(MuzzleOff());
            }
        }
    }
    }


    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        Flash.SetActive(false);
    }


}
