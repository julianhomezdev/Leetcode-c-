using System;
public class Solution
{
    
    //
    public int[] TwoSum(int[] nums, int target)
    {

        // Dictionary to storage (number, index)
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            // What is needed
            int complement = target - nums[i];

            // Search what is needed in the dictionary
            if (map.ContainsKey(complement))
            {
                // if it is in the dictionary we return the current index
                // and the index of the complement saved in the dictionary
                return new int[] { map[complement], i };
            }
            // if not contains simply add it to the dictionary
            map[nums[i]] = i;
        }

        return new int[0];





    }
}


public class Program
{
    public static void Main()
    {

        Solution sol = new Solution();

        int[] nums = { 3, 2, 4 };
        int target = 6;

        int[] result = sol.TwoSum(nums, target);

        for (int i = 0; i <= result.Length - 1; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

