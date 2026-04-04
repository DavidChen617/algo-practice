namespace NeedCode._50_Pow;

public class Solution2
{
    public double MyPow(double x, int n)
    {
        if (x == 0)
            return 0;

        if (n == 0)
            return 1;

        var res = DFS(Math.Abs((long)n));

        return n < 0 ? 1 / res : res;

        double DFS(long exponent)
        {
            if (exponent == 0)
                return 1;

            var half = DFS(exponent / 2);

            return (exponent % 2 == 0) ? half * half : x * half * half;
        }
    }
}
