using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour {

    //public  GameObject[] goArray = SceneManager.GetSceneByBuildIndex(1).GetRootGameObjects();
    // Use this for initialization

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void RreStart()
    {
        SceneManager.LoadScene(1);
       // SceneManager.GetSceneByBuildIndex(1).GetGameobject
    }

}
