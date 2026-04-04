namespace NeedCode._2013_DetectSquares;

public class Solution1
{
}

public class CountSquares
{
    private readonly Dictionary<(int X, int Y), int> _ptCount = new();
    private readonly List<(int X, int Y)> _pts = new();

    public CountSquares()
    {
    }

    public void Add(int[] point)
    {
        var tuplePoint = (point[0], point[1]);
        _ptCount.TryAdd(tuplePoint, 0);

        _ptCount[tuplePoint]++;
        _pts.Add(tuplePoint);
    }

    public int Count(int[] point)
    {
        int px = point[0],
            py = point[1],
            res = 0;

        for (int i = 0; i < _pts.Count; i++)
        {
            var pt = _pts[i];
            if (Math.Abs(py - pt.Y) != Math.Abs(px - pt.X) || pt.X == px || py == pt.Y)
                continue;
            
            res += _ptCount.GetValueOrDefault((pt.X, py)) *
                _ptCount.GetValueOrDefault((px, pt.Y));
        }

        return res;
    }
}
