namespace KeysAndRooms;

public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var openRooms = new bool[rooms.Count];

        DepthFirstSearch(rooms, openRooms, 0);
        
        return !openRooms.Contains(false);
    }

    private static void DepthFirstSearch(IList<IList<int>> rooms, bool[] openRooms, int numberRoom)
    {
        if (openRooms[numberRoom])
            return;
        
        openRooms[numberRoom] = true;
        
        foreach (int key in rooms[numberRoom])
            DepthFirstSearch(rooms, openRooms, key);
    }
}