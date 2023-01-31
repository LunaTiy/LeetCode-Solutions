namespace BestTeamWithNoConflicts;

public class Solution
{
    public int BestTeamScore(int[] scores, int[] ages)
    {
        List<(int age, int score)> ageScorePairs = scores
            .Select((score, i) => (ages[i], score))
            .ToList();

        ageScorePairs.Sort((x, y) => x.score == y.score ? x.age - y.age : x.score - y.score);

        var highestAge = ages.Max();
        var bits = new int[highestAge + 1];
        var result = int.MinValue;

        foreach ((int age, int score) ageScore in ageScorePairs)
        {
            int currentBest = ageScore.score + QueryBit(bits, ageScore.age);
            UpdateBit(bits, ageScore.age, currentBest);

            result = Math.Max(result, currentBest);
        }

        return result;
    }

    private static int QueryBit(int[] bits, int age)
    {
        var maxScore = int.MinValue;

        for (int i = age; i > 0; i -= i & -i)
            maxScore = Math.Max(maxScore, bits[i]);

        return maxScore;
    }

    private static void UpdateBit(int[] bits, int age, int currentBest)
    {
        for (int i = age; i < bits.Length; i += i & -i)
            bits[i] = Math.Max(bits[i], currentBest);
    }
}