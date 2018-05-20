using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGDamage : MonoBehaviour {
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15.0f;
    public RaycastHit hit;
    public GameObject smg;
    public GameObject TheBullet;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("Fire1")) {
            
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
                            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                            {
                                Instantiate(TheBullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                            }
                        }
                        }
                    }
                }
        }
    }
    
}
