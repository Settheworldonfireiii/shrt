using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausMenu : MonoBehaviour {


    public GameObject Paussee;

    public void onResume()
    {
        Paussee.SetActive(false);
        Time.timeScale = 1;
    }

    public void onMainMenu()
    {        
        SceneManager.LoadScene(0);
    }
}
