using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuck : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);
       



    }
}
