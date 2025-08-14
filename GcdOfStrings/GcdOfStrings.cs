public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {

        int lengthStr1 = str1.Length;
        int lengthStr2 = str2.Length;


        if (str1 + str2 != str2 + str1)
        {
            return "";
        }

        int min = mcd(lengthStr1, lengthStr2);


        string gdcPattern = str1.Substring(0, min);

        return gdcPattern;
        



    }

    public int mcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }


        return a;
    }
}