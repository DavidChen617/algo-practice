namespace NeedCode._678_CheckValidString;

public class Solution1
{
    public bool CheckValidString(string s)
    {
        // 紀錄 ( 未被處理的範圍
        int min = 0, max = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c == '(')
            {
                ++min;
                ++max;
            }
            else if (c == ')')
            {
                min = Math.Max(0, min - 1);
                --max;
                // ) 左邊沒有對應的 (, 直接失敗
                if (max < 0)
                    return false;
            }
            else
            {
                min = Math.Max(0, min - 1);
                ++max;
            }
        }
        
        return min == 0; // ( 是否有被處理完
    }
}
