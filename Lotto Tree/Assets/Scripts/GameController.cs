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
        timeLeft = 240.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0){
            timeLeft = 240.0f;
            for (int i = 0; i < 6; i++){
                currentDraw[i] = Random.Range(1, 82);
            }
        }

        if (timeLeft <= 120){
            //to-do: leaf falling
            foreach(GameObject leaf in GameObject.FindGameObjectsWithTag("Leaf")){
                leaf.transform.Translate(0, Time.deltaTime, 0);
            }
        }

        timeLeft -= Time.deltaTime;

    }
}
