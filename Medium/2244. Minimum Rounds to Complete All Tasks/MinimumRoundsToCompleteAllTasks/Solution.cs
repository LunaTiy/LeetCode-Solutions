namespace MinimumRoundsToCompleteAllTasks;

public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        Dictionary<int, int> countTasksMap = new();

        foreach (int task in tasks)
        {
            if (countTasksMap.ContainsKey(task)) countTasksMap[task]++;
            else countTasksMap.Add(task, 1);
        }

        List<int> tasksCount = countTasksMap
            .Select(x => x.Value)
            .ToList();

        var rounds = 0;

        while (tasksCount.Count > 0)
        {
            if (tasksCount[0] == 1)
                return -1;

            if (tasksCount[0] == 3 || tasksCount[0] >= 5)
                tasksCount[0] -= 3;
            else
                tasksCount[0] -= 2;
            
            if(tasksCount[0] == 0)
                tasksCount.RemoveAt(0);

            rounds++;
        }
        
        return rounds;
    }
}