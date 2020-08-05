using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timeLeft;
    private TextMeshPro textmeshPro;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 240.0f;
        textmeshPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        textmeshPro.SetText("{0}:{1}",(int)(timeLeft/60), (int)(timeLeft%60));
        if (timeLeft <= 0){
            timeLeft = 240.0f;
        }
    }
}
