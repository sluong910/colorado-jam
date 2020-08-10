using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision detected");
        if (other.gameObject.CompareTag("Leaf"))
        {
            Leaf leaf = other.gameObject.GetComponent<Leaf>();
            BroadcastMessage("IncrementLabel", leaf.leafNum);
            Destroy(other.gameObject);
        }
    }


}
