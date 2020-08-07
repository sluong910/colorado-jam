using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafGenerator : MonoBehaviour
{

    private static System.Random m_rng = new System.Random();
    private List<(int, int)> m_leafList = new List<(int, int)>();
    private int m_MaxLeaves = 15;

    // Start is called before the first frame update
    void Start()
    {
        List<int> leaves1 = RandomNumbersToSum(50, 15);
        Debug.Log(string.Join(" ", leaves1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateLeafList(int[] drawing)
    {
        for(int i = 0; i < drawing.Length; i++){
            foreach(int leaf in RandomNumbersToSum(drawing[i], m_MaxLeaves)){
                m_leafList.Add((leaf, i));
            }
        }

        Shuffle(m_leafList);

        Debug.Log(string.Join(" ", m_leafList));

    }

    private void Shuffle(List<(int, int)> list)  
    {  
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = m_rng.Next(n + 1);  
            (int, int) value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }  
    }

    private List<int> RandomNumbersToSum(int sum, int maxN) {
        List<int> randNums = new List<int>();
        int genSum = 0;

        int i = 0;
        while (genSum < sum) {
            // If the max number of leaves is reached, make the last number the remainder from sum
            if (i == maxN-1) {
                randNums.Add(sum-genSum);
                return randNums;
            }

            int randn = Random.Range(1,10);
            genSum += randn;
            randNums.Add(randn);
            i++;
        }

        // If the generated sum is larger than intended, subtract from the last number in list
        if (genSum > sum) {
            randNums[randNums.Count - 1] -= genSum-sum;
        }

        return randNums;
    }

    
}
