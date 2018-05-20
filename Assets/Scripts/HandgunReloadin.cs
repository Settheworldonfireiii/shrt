using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunReloadin : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public GunFire GunComponent;
    void Start() {
        GunComponent = GetComponent<GunFire>();
    }
    void Update() {
        ClipCount = GlobalAmmo.CurrentAmmo;
        ReserveCount = GlobalAmmo.LoadedAmmo;
        if (ReserveCount == 0) {
            ReloadAvailable = 0;
        } else {
            ReloadAvailable = 10 - ClipCount;
        } if (Input.GetButtonDown("Reload")) {
            if (ReloadAvailable >= 1) {
                if (ReserveCount <= ReloadAvailable) {
                    GlobalAmmo.CurrentAmmo += ReserveCount;
                    GlobalAmmo.LoadedAmmo -= ReserveCount;
                    ActionReload();
                } else {
                    GlobalAmmo.CurrentAmmo += ReloadAvailable;
                    GlobalAmmo.LoadedAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());
        }
    }
    IEnumerator EnableScripts() {
        yield return new WaitForSeconds(1.1f);
      GunComponent.enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true); }
    void ActionReload() {
        GunComponent.enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("HandgunReload");
    }
}
