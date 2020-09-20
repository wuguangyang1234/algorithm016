using System;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // int i=0;
        // for(int j=0;j<nums.Length;j++){
        //     if(nums[j]!=0){
        //         nums[i++]=nums[j];
        //     }
        // }
        // for(int j=i;j<nums.Length;j++){
        //     nums[j]=0;
        // }
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j++] = tmp;
            }
        }
    }
}