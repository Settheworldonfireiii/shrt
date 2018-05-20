using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15.0f;
    public GameObject gun;
    public GameObject smg;
    public GameObject TheBullet;
    public RaycastHit hit;
    public int i = 0;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            if (gun.active == true) {
                if (GlobalAmmo.CurrentAmmo > 0)
                {
                    RaycastHit Shot;
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                    {
                       
                            

                        if (TargetDistance < AllowedRange)
                        {
                            Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                            {
                                Instantiate(TheBullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));

                                TheBullet.SetActive(true);
                              
                               

                            }
                        }
                    }
                }
                 if (smg.active == true)
                {
                    if (GlobalAmmo.CurrentSMGAmmo > 0)
                    {
                        RaycastHit Shot;
                        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                        {
                            TargetDistance = Shot.distance;

                            if (TargetDistance < AllowedRange)
                            {
                                Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                            }
                        }
                    }
                }
        }
    }
    }

    }

