﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jimmy Vegas Unity Tutorial
// These scripts will manage your health and updated AI



//GLOBAL HEALTH
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{

    public static int PlayerHealth = 10;
    public int InternalHealth;
    public GameObject HealthDisplay;

    void Update()
    {
        InternalHealth = PlayerHealth;
        HealthDisplay.GetComponent<Text>().text = "Health: " + PlayerHealth;
        if (PlayerHealth == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}




