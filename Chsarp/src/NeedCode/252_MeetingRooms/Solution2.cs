namespace NeedCode._252_MeetingRooms;

public class Solution2
{
    public bool CanAttendMeetings(List<Interval> intervals)
    {
        intervals.Sort((a, b) => a.start - b.start);
        
        for (int i = 1; i < intervals.Count; i++)
        {
            if (intervals[i - 1].end > intervals[i].start)
                return false;
        }
        return true;
    }
}
