using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BoxLabel : MonoBehaviour
{

    private TextMeshPro boxLabel;
    private int boxTotal;

    // Start is called before the first frame update
    void Start()
    {
        boxLabel = GetComponent<TextMeshPro>();
        boxTotal = 0;
        IncrementLabel(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncrementLabel(int i)
    {
        boxTotal += i;
        boxLabel.SetText(String.Format("{0}", boxTotal));
        boxLabel.ForceMeshUpdate(true);
    }
}
