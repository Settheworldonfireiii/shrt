using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGReloading : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;
    public SMGFire SMGComponent;
    void Start() {
        SMGComponent = GetComponent<SMGFire>();
    }
    void Update() {
        ClipCount = GlobalAmmo.CurrentSMGAmmo;
        ReserveCount = GlobalAmmo.LoadedSMGAmmo;
        if (ReserveCount == 0) {
            ReloadAvailable = 0;
        } else {
            ReloadAvailable = 30 - ClipCount;
        } if (Input.GetButtonDown("Reload")) {
            if (ReloadAvailable >= 1) {
                if (ReserveCount <= ReloadAvailable) {
                    GlobalAmmo.CurrentSMGAmmo += ReserveCount;
                    GlobalAmmo.LoadedSMGAmmo -= ReserveCount;
                    ActionReload();
                } else {
                    GlobalAmmo.CurrentSMGAmmo += ReloadAvailable;
                    GlobalAmmo.LoadedSMGAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());
        }
    }
    IEnumerator EnableScripts() {
        yield return new WaitForSeconds(1.1f);
      SMGComponent.enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true); }
    void ActionReload() {
        SMGComponent.enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("SMGReload");
    }
}
