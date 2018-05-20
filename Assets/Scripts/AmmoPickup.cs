using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {
    public AudioSource AmmoSound;
    void OnTriggerEnter(Collider other) {
        AmmoSound.Play();
        if (GlobalAmmo.CurrentAmmo == 0) {
            GlobalAmmo.CurrentAmmo += 10;
            this.gameObject.SetActive(false);
        } else {
            GlobalAmmo.LoadedAmmo += 10;
            this.gameObject.SetActive(false);
        }
    }
}