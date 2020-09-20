using System;
using System.Collections.Generic;
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        // return nums1.Intersect(nums2).ToArray();

        if (nums1.Length < 1 || nums2.Length < 1) return new int[] { };
        List<int> res = new List<int>();
        HashSet<int> hs = new HashSet<int>();
        HashSet<int> hs1 = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            hs.Add(nums1[i]);
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (hs.Contains(nums2[i]) && !hs1.Contains(nums2[i]))
            {
                res.Add(nums2[i]);
                hs1.Add(nums2[i]);
                hs.Remove(nums2[i]);
            }
        }
        return res.ToArray();
    }
}
