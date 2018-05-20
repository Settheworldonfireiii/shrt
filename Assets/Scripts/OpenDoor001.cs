using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenDoor001 : MonoBehaviour {
    public GameObject TextDisplay;
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TheDoor;
    void Update() {
        TheDistance = PlayerCasting.DistanceFromTarget;

}
    void OnMouseOver() {
        if (TheDistance <= 2) {
            TextDisplay.GetComponent<Text>().text = "Press Button";
        }


        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(OpenTheDoor());
            }
        }
    }
    void OnMouseExit() {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator OpenTheDoor() {
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1f);
        TheDoor.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(5);
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
    }
}