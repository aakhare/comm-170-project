using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class score : MonoBehaviour
{
    //public GameObject [] recyclableItems;
    public int scoreCount = 0; 
    public TMP_Text scoreUI;
    public void calculateScore(int points){
        scoreCount += points;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score: " + scoreCount.ToString();
    }
}
