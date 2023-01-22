using System.Text;

namespace PalindromePartitioning;

public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        var result = new List<IList<string>>();
        Recursion(0, new List<string>(), s, result);
        
        return result;
    }

    private static void Recursion(int currentIndex, IList<string> currentList, string s, ICollection<IList<string>> result)
    {
        if (currentIndex == s.Length)
        {
            result.Add(new List<string>(currentList));
            return;
        }

        for (int i = currentIndex; i < s.Length; i++)
        {
            if(!IsPalindrome(s, currentIndex, i)) continue;
            
            currentList.Add(s.Substring(currentIndex, i - currentIndex + 1));
            Recursion(i + 1, currentList, s, result);
            currentList.RemoveAt(currentList.Count - 1);
        }
    }

    private static bool IsPalindrome(string s, int startIndex, int endIndex)
    {
        while (startIndex <= endIndex)
        {
            if (s[startIndex] != s[endIndex])
                return false;

            startIndex++;
            endIndex--;
        }

        return true;
    }
}