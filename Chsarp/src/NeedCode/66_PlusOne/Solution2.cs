namespace NeedCode._66_PlusOne;

public class Solution2
{
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        for (int i = n - 1; i >= 0; --i)
        {
            if (digits[i] < 9)
            {
                ++digits[i];
                return digits;
            }
            digits[i] = 0;
        }
        
        var result = new int[n + 1];
        result[0] = 1;
        return result;
    }
}
