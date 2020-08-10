using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    private int timeLeft;
    private static int playTime = 60; //how often game is drawn in seconds
    private TextMeshPro textmeshPro;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 0;
        textmeshPro = GetComponent<TextMeshPro>();
        InvokeRepeating("decreaseTime", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0){
            timeLeft = playTime;
            SendMessageUpwards("StartDraw");
        }
        textmeshPro.SetText(String.Format("Next Draw In:\n{0}:{1}", timeLeft/60, (timeLeft%60).ToString("D2") ));
        
    }

    void decreaseTime()
    {
        timeLeft--;
    }
}
