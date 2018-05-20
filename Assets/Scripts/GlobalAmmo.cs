using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalAmmo : MonoBehaviour {
    public static int CurrentAmmo;
    public static int CurrentSMGAmmo;
    public int InternalAmmo;
    public int InternalSMGAmmo;

    public GameObject gun;
    public GameObject smg;
    public GameObject AmmoDisplay;
    public GameObject SMGAmmoDisplay;

    public static int LoadedAmmo;
    public static int LoadedSMGAmmo;
    public int InternalLoaded;
    public int InternalSMGLoaded;
    public GameObject LoadedDisplay;
    public GameObject LoadedSMGDisplay;
    public GameObject Label9mm;
    public GameObject SMGlabel;


    public GameObject ScoreLabel;



    public GameObject AmmoDisplayer;
    public GameObject SMGAmmoDisplayer;


    public GameObject Task1;
    public GameObject Task2;
    public GameObject Task3;

    public GameObject Objectives;

    public GameObject GoAndPlay;

    public static bool isGunPicked = false;
    public  static bool isSMGPicked = false;
    void Update()
    {
        if (gun.active)
        {
            InternalAmmo = CurrentAmmo;
            InternalLoaded = LoadedAmmo;
            AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
            LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;
            if (Input.GetButtonDown("ChangeGun")&&(isSMGPicked == true))
            {
                gun.SetActive(false);
                smg.SetActive(true);

                Label9mm.SetActive(false);
                SMGlabel.SetActive(true);
              
                AmmoDisplayer.SetActive(false);
                SMGAmmoDisplayer.SetActive(true);

                
                
                
            }

        }
        else if (smg.active)
        {
            InternalSMGAmmo = CurrentSMGAmmo;
            InternalSMGLoaded = LoadedSMGAmmo;
            SMGAmmoDisplay.GetComponent<Text>().text = "" + InternalSMGAmmo;
            LoadedSMGDisplay.GetComponent<Text>().text = "" + LoadedSMGAmmo;
            if (Input.GetButtonDown("ChangeGun")&&(isGunPicked == true))
            {
                gun.SetActive(true);
                smg.SetActive(false);


                Label9mm.SetActive(true);
                SMGlabel.SetActive(false);
                SMGAmmoDisplayer.SetActive(false);
                AmmoDisplayer.SetActive(true);
               
              
                

            }
        }

        if ((Task1.active) && (Task2.active) && (Task3.active)){
            Objectives.SetActive(false);
            StartCoroutine(DestrScor());
            GoAndPlay.SetActive(true);
            StartCoroutine(Watte());
        }
    }


   IEnumerator Watte()
    {
        yield return new WaitForSeconds(5f);
        GoAndPlay.SetActive(false);
    }

    IEnumerator DestrScor()
    {
        yield return new WaitForSeconds(1.5f);
        ScoreLabel.SetActive(false);
    }
}
