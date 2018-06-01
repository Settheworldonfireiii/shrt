using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pausee : MonoBehaviour
{

    public GameObject Paussee;
    void Update()
    {

    

        if (Input.GetKeyDown(KeyCode.Escape))
        {

           if(Paussee.activeInHierarchy == true)
            {
                Paussee.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Paussee.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    


}

