using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore25 : MonoBehaviour {
    public GameObject ObjectiveComplete;

    // Use this for initialization
    void DeductPoints(int DamageAmount)
    {
        GlobalScore.CurrentScore += 25;
        ObjectiveComplete.SetActive(true);
    }
}
