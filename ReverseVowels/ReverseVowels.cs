public class Solution {
    public string ReverseVowels(string s)
    {

        List<string> vowels = new List<string>() { "a", "e", "i", "o", "u" };


        List<string> vowelsIn = new List<string>();

        for (int i = 0; i <= s.Length -1; i++)
        {
            if (vowels.Contains(char.ToLower(s[i]).ToString()))
            {
                vowelsIn.Insert(0, s[i].ToString());
            }

        }

        string reversedVowels = "";

        for (int i = 0; i <= s.Length -1; i++)
        {
            if (vowels.Contains(char.ToLower(s[i]).ToString()))
            {
                reversedVowels += vowelsIn[0];
                vowelsIn.RemoveAt(0);
            }
            else
            {
                 reversedVowels += s[i];
            }

            

        }


        return reversedVowels;
        


        



    }
}