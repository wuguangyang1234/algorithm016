using System;
using System.Collections;
using System.Collections.Generic;
/*1.两数之和
     */
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable ht = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];
            if (ht.ContainsKey(result) && (int)ht[result] != i)
            {
                return new int[] { (int)ht[result], i };
            }
            else if (!ht.ContainsKey(nums[i]))
            {
                ht.Add(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
    }
}
