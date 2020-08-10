using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{

    public GameObject m_grayBoxPrefab;
    public GameObject m_goldBoxPrefab;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        for (int i = 0; i < 5; i++)
        {
            Vector3 worldCoord = camera.ViewportToWorldPoint(new Vector3((2*i + 1)/12.0f, 0.15f, 1));
            Instantiate(m_grayBoxPrefab, worldCoord, Quaternion.identity);
        }

        Vector3 lastCoord = camera.ViewportToWorldPoint(new Vector3((11)/12.0f, 0.15f, 1));
        Instantiate(m_goldBoxPrefab, lastCoord, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ClearBoxes()
    {
        Debug.Log("clearing boxes");
        foreach (BoxLabel b in FindObjectsOfType<BoxLabel>())
        {
            b.ClearBox();
        }
    }

}
