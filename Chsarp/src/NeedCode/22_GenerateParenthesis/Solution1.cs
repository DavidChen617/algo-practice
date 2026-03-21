namespace NeedCode._22_GenerateParenthesis;

public class Solution1
{
    public List<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        DFS(0, 0, string.Empty);
        return result;

        void DFS(int left, int right, string stack)
        {
            if (left == n && left == right)
            {
                result.Add(stack);
                return;
            }

            if (left < n)
                DFS(left + 1, right, stack + '(');
            if(right < left)
                DFS(left, right + 1, stack + ')');
        }
    }
}
