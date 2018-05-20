using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGAmmoPickUp : MonoBehaviour {
    public AudioSource AmmoSound;
    void OnTriggerEnter(Collider other) {
        AmmoSound.Play();
        if (GlobalAmmo.CurrentSMGAmmo == 0) {
            GlobalAmmo.CurrentSMGAmmo += 30;
            this.gameObject.SetActive(false);
        } else {
            GlobalAmmo.LoadedSMGAmmo += 30;
            this.gameObject.SetActive(false);
        }
    }
}