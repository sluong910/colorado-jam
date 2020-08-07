using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafGenerator : MonoBehaviour
{
    private List<int> RandomNumbersToSum(int sum, int max_n) {
        List<int> rand_nums = new List<int>();
        int gen_sum = 0;

        int i = 0;
        while (gen_sum < sum) {
            // If the max number of leaves is reached, make the last number the remainder from sum
            if (i == max_n-1) {
                rand_nums.Add(sum-gen_sum);
                return rand_nums;
            }

            int randn = Random.Range(1,10);
            gen_sum += randn;
            rand_nums.Add(randn);
            i++;
        }

        // If the generated sum is larger than intended, subtract from the last number in list
        if (gen_sum > sum) {
            rand_nums[rand_nums.Count - 1] -= gen_sum-sum;
        }

        return rand_nums;
    }

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
}
