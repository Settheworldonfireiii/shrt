using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpMP5K : MonoBehaviour {

    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;
    public GameObject FakeGun;
    public GameObject RealGun;
 
    public GameObject OtherGun;
    public AudioSource PickUpAudio;
    public GameObject SMGlabel;
    public GameObject Label9mm;


    public GameObject AmmoDisplayer;
    public GameObject SMGAmmoDisplayer;


    void Update() {
        TheDistance = PlayerCasting.DistanceFromTarget;
       
    }


    void OnMouseOver() {
        if (TheDistance <= 2) {
            TextDisplay.GetComponent<Text>().text = "Take MP5K Machine Gun";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeSMG());
                
            }
        }
    }


    void OnMouseExit() {
        TextDisplay.GetComponent<Text>().text = "";
    }


    IEnumerator TakeSMG() {
        PickUpAudio.Play();

        transform.position =new Vector3(0, -1000, 0);

        FakeGun.SetActive(false);
        OtherGun.SetActive(false);

      

        RealGun.SetActive(true);
        
        Label9mm.SetActive(false);
        SMGlabel.SetActive(true);

        SMGAmmoDisplayer.SetActive(true);
        AmmoDisplayer.SetActive(false);

  

        GlobalAmmo.isSMGPicked = true;
        yield return new WaitForSeconds(0.1f);
    }
}
