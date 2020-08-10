using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LeafLabel : MonoBehaviour
{

    private TextMeshPro leafLabel;
    private int leafNum;

    // Start is called before the first frame update
    void Start()
    {
        leafLabel = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        leafLabel.SetText(String.Format("{0}", leafNum));
        leafLabel.ForceMeshUpdate(true);
    }

    private void SetLabel(int label)
    {
        // leafLabel = GetComponent<TextMeshPro>();
        // leafLabel.SetText(String.Format("{0}", label));
        // leafLabel.ForceMeshUpdate(true);

        leafNum = label;
    }
}
