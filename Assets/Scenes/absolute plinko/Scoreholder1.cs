﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreholder : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreValue = 0;
    Text score;
    /*public void IncrementScore()
    {
        score+;
        text.GetComponent<Text>().text = score.ToString();
    }*/
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
