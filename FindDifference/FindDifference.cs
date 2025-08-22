public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {

        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);

        HashSet<int> first = new HashSet<int>();
        HashSet<int> second = new HashSet<int>();


        foreach (int num in set1)
        {
            if (!set2.Contains(num))
                first.Add(num);
        }


        foreach (int num in set2)
        {
            if (!set1.Contains(num))
                second.Add(num);
        }

        return new List<IList<int>> { first.ToList(), second.ToList() };

    }
}   