using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class MainMenuOpts : MonoBehaviour {

    // Use this for initialization

 

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CreditScene()
    {
        SceneManager.LoadScene(3);
    }

    public void ExIt()
    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }

}

