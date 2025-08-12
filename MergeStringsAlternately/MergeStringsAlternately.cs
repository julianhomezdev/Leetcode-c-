public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {

        int lnWord1 = word1.Length;
        int lnWord2 = word2.Length;
        string finalString = "";

        if (lnWord1 == lnWord2)
        {

            for (int i = 0; i <= lnWord1 - 1; i++)
            {
                finalString += word1[i];
                finalString += word2[i];
            }

        }
        else if (lnWord1 > lnWord2)
        {
            for (int i = 0; i <= lnWord2 - 1; i++)
            {
                finalString += word1[i];
                finalString += word2[i];

            }

            finalString += word1.Substring(lnWord2, lnWord1 - lnWord2);
        }
        else
        {
            for (int i = 0; i <= lnWord1 - 1; i++)
            {
                finalString += word1[i];
                finalString += word2[i];

            }

            finalString += word2.Substring(lnWord1, lnWord2 - lnWord1);
        }






        return finalString;
    }
}


