namespace CanPlaceFlowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
            return true;

        if (flowerbed.Length == 1)
            return flowerbed[0] == 0;

        if (flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            flowerbed[0] = 1;
            n--;
        }

        for (int i = 1; i < flowerbed.Length - 1 && n > 0; i++)
        {
            if (flowerbed[i] == 1 || flowerbed[i - 1] != 0 || flowerbed[i + 1] != 0)
                continue;
            
            flowerbed[i] = 1;
            n--;
        }
        
        if (n > 0 && flowerbed[^2] == 0 && flowerbed[^1] == 0)
        {
            flowerbed[^1] = 1;
            n--;
        }

        return n == 0;
    }
}