using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulla : MonoBehaviour {

    // Use this for initialization
    public GameObject TheBullet;
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Deestr());
	}


    IEnumerator Deestr()
    {

        yield return new WaitForSeconds(3f);
        
        DestroyObject(TheBullet);
    }
}
