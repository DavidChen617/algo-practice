namespace NeedCode._75_MissingNumber;

public class Solution1
{
    // nums = [3, 0, 1]
    // xor ^ i ^ nums[i]
    // xor      11
    // i        00 
    // nums[i]  11 
    // = 00
    // xor      00
    // i        01
    // nums[i]  00
    // = 01
    // xor      01     
    // i        10
    // nums[i]  01
    // = 10
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length,
            xor = n;

        for (int i = 0; i < n; i++)
        {
            xor = xor ^ i ^ nums[i];
        }

        return xor;
    }
}
