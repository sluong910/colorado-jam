using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private int[] currentDraw;
    private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        currentDraw = new int[6];
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void StartDraw(){
        for (int i = 0; i < 6; i++){
            currentDraw[i] = Random.Range(1, 82);
        }

        Debug.Log(string.Join(" ", currentDraw));
    }
}
