using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

    public GameObject Flash;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        { 
            if(GlobalAmmo.CurrentAmmo > 0) { 
            AudioSource sound = gameObject.GetComponent<AudioSource>();
            sound.Play();
            Flash.SetActive(true);
            GetComponent<Animation>().Play("GunShot");
            GlobalAmmo.CurrentAmmo -= 1;
            StartCoroutine(MuzzleOff());
            }
        }
       
    }


    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        Flash.SetActive(false);
    }
}
