namespace NeedCode._371_SumOfTwoIntegers;

public class Solution1
{
    public int GetSum(int a, int b)
    {
        while (b != 0)
        {
            int temp = (a & b) << 1;
            a ^= b;
            b = temp;
        }
        
        return a;
    }
}
