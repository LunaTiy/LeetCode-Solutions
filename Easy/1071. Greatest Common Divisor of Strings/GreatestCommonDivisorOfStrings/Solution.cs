namespace GreatestCommonDivisorOfStrings;

public class Solution
{
    public string GcdOfStrings(string str1, string str2) => 
        (str1 + str2 == str2 + str1) ? str1[..Gcd(str1.Length, str2.Length)] : "";

    private static int Gcd(int len1, int len2)
        => len2 == 0 ? len1 : Gcd(len2, len1 % len2);
}