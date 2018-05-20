using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp9mm : MonoBehaviour {

    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;
    public GameObject FakeGun;
    public GameObject RealGun;

    public AudioSource PickUpAudio;
    public GameObject OtherGun;
    public GameObject ObjectiveComplete;
    public GameObject SMGlabel;
    public GameObject Label9mm;

    public GameObject AmmoDisplayer;
    public GameObject SMGAmmoDisplayer;

    void Update() {
        TheDistance = PlayerCasting.DistanceFromTarget;
       
    }


    void OnMouseOver() {
        if (TheDistance <= 2) {
            TextDisplay.GetComponent<Text>().text = "Take 9mm Pistol";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeNineMil());
                ObjectiveComplete.SetActive(true);
            }
        }
    }


    void OnMouseExit() {
        TextDisplay.GetComponent<Text>().text = "";
    }


    IEnumerator TakeNineMil() {
        PickUpAudio.Play();
        transform.position =new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        OtherGun.SetActive(false);

        

        

        RealGun.SetActive(true);

        Label9mm.SetActive(true);
        SMGlabel.SetActive(false);

        SMGAmmoDisplayer.SetActive(false);
        AmmoDisplayer.SetActive(true);

       

        GlobalAmmo.isGunPicked = true;
        yield return new WaitForSeconds(0.1f);
    }
}
