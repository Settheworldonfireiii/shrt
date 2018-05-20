using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {

    public GameObject Curs1;
    public GameObject Curs2;
    public GameObject Curs3;
    public GameObject Curs4;
    public bool CR_running;
    void Update(){
        if(Input.GetButtonDown("Fire1")){
            Curs1.GetComponent<Animator>().enabled = true;
            Curs2.GetComponent<Animator>().enabled = true;
            Curs3.GetComponent<Animator>().enabled = true;
            Curs4.GetComponent<Animator>().enabled = true;
           StartCoroutine(WaitingAnim());

        }
    }
    IEnumerator WaitingAnim() {
       CR_running = true;
       
      yield return new WaitForSeconds(0.04f); //один кадр анимации эквивалентен 0.01
       CR_running = false;
       Curs1.GetComponent<Animator>().enabled = false;
       Curs2.GetComponent<Animator>().enabled = false;
       Curs3.GetComponent<Animator>().enabled = false;
       Curs4.GetComponent<Animator>().enabled = false;
}
}
