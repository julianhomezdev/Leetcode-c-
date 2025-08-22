public class Solution {
    public bool IsSubsequence(string s, string t)
    {


        int pointerOne = 0;

        for (int pointerTwo = 0; pointerTwo <= t.Length - 1; pointerTwo++)
        {



            if (t[pointerTwo] == s[pointerOne])
            {
                pointerOne++;
            }
            
            if (pointerOne == s.Length)
            {
                return true;
            }
        }

        return false;

    }
}