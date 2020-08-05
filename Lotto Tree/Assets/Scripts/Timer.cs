using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timeLeft;
    private TextMeshProUGUI textmeshPro;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 240.0f;
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        textmeshPro.SetText("Something");
        // textmeshPro.SetText("{0}",timeLeft);
    }
}
