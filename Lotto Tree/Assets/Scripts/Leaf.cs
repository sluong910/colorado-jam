﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -Time.deltaTime, 0);
    }

    public void SetLeafNum(int num)
    {
        BroadcastMessage("SetLabel", num);
    }
}
