namespace LeetCode22;

public class Solution
{
    public static bool CloseStrings(string word1, string word2)
    {
        Dictionary<char, int> dict1 = new Dictionary<char, int>(26);
        foreach (char i in word1)
            if (!dict1.TryAdd(i, 1))
                dict1[i] += 1;

        Dictionary<char, int> dict2 = new Dictionary<char, int>(26);
        foreach (char i in word2)
            if (dict1.ContainsKey(i))
            {
                if (!dict2.TryAdd(i, 1)) dict2[i] += 1;
            }
            else return false;

        var values1 = dict1.Values.ToList();
        values1.Sort();
        var values2 = dict2.Values.ToList();
        values2.Sort();

        for (int i  = 0; i < values1.Count; i++)
        {
            if (values1[i] < values2[i])
            {
                return false;
            }
        }
        return true;
    }

    //public static void Main()
    //{
    //    string word1 = "a";
    //    string word2 = "b";

    //    var value = CloseStrings(word1, word2);
    //    Console.WriteLine(value);
    //}
}