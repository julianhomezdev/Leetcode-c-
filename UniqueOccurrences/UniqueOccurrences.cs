public class Solution {
    public bool UniqueOccurrences(int[] arr)
    {


        Dictionary<int, int> concurrences = new Dictionary<int, int>();



        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (concurrences.ContainsKey(arr[i]))
            {
                concurrences[arr[i]] += 1;
            }
            else
            {
                concurrences[arr[i]] = 1;
            }

        }

        HashSet<int> times = new HashSet<int>();


        foreach (int value in concurrences.Values)
        {
            times.Add(value);
        }

        if (concurrences.Count != times.Count)
        {
            return false;
        }


        return true;


    }
}