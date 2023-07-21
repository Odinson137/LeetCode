
using System.Text;

public class Solution1
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder word3 = new StringBuilder();
        int lenWord1 = word1.Length;
        int lenWord2 = word2.Length;

        int len;
        if (lenWord1 > lenWord2) len = lenWord2;
        else len = lenWord1;

        int i;
        for (i = 0; i < len; i++)
        {
            word3.Append(word1[i]);
            word3.Append(word2[i]);
        }

        if (word2.Length > i)
        {
            for (; lenWord2 - 1 >= i; i++)
                word3.Append(word2[i]);
        }
        else
        {
            for (; lenWord1 - 1 >= i; i++)
                word3.Append(word1[i]);
        }

        return word3.ToString();
    }
}