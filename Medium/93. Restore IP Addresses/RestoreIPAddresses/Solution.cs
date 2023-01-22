namespace RestoreIPAddresses;

public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        var res = new List<string>();
        var tempList = new List<string>();

        DFS(s, res, tempList);

        return res;
    }

    private static void DFS(string s, List<string> res, List<string> tempList)
    {
        if (tempList.Count() == 4)
        {
            if (s.Length == 0) res.Add(string.Join(".", tempList));
            
            return;
        }

        for (var i = 1; i <= 3; i++)
        {
            if (s.Length < i)
                break;

            string substring = s[..i];

            if (int.Parse(substring) > 255 || substring.StartsWith('0') && substring.Length != 1)
                continue;

            tempList.Add(substring);
            DFS(s.Length == i ? "" : s[i..], res, tempList);
            tempList.RemoveAt(tempList.Count() - 1);
        }
    }
}