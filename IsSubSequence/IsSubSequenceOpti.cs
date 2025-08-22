public class Solution
{
    public bool IsSubsequence(string s, string t)
    {

        // Dict to storage the position letters in t in order

        Dictionary<char, List<int>> map = new Dictionary<char, List<int>>();

        for (int i = 0; i < t.Length; i++)
        {
            if (map.ContainsKey(t[i]))
            {
                map[t[i]].Add(i);
            }
            else
            {
                map[t[i]] = new List<int> { i };
            }

        }

        int prevIndex = -1;


        foreach (char ch in s)
        {

            if (!map.ContainsKey(ch))
            {
                return false;    
            }

            int resultBS = BinarySearch(map[ch], prevIndex);

            if (resultBS == -1)
            {
                return false;
            }

            prevIndex = resultBS;

        }

        return true;

    }

    public int BinarySearch(List<int> indexes, int prev)
    {
        int left = 0;
        int right = indexes.Count - 1;
        int candidate = -1;
        int mid;

        while (left <= right)
        {
            mid = (left + right) / 2;

            // - pero > prev
            // ej -> prev = -1
            // index = [2, 4, 7, 8, 12, 15]

            if (indexes[mid] <= prev)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
                candidate = indexes[mid];
            }
        }

        return candidate;
    }
}