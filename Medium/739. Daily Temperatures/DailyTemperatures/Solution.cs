namespace DailyTemperatures;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var indicesArray = new int[temperatures.Length];
        
        var countElementsInArray = 0;

        for (var i = 0; i < temperatures.Length; i++)
        {
            while (countElementsInArray > 0 && temperatures[i] > temperatures[indicesArray[countElementsInArray - 1]])
            {
                int index = indicesArray[countElementsInArray - 1];
                result[index] = i - index;
                countElementsInArray--;
            }

            indicesArray[countElementsInArray] = i;
            countElementsInArray++;
        }
        
        return result;
    }
}