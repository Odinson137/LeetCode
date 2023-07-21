
public class Solution2
{
    public string GcdOfStrings(string str1, string str2)
    {
        int gcd = EuclideanGCD(str1.Length, str2.Length);

        string str3 = "";

        int i = 0;
        while (i < gcd)
        {
            str3 += str1[i++];
        }

        int i1 = 0;
        while (i1 < str1.Length)
        {
            if (str1.Substring(i1, gcd) != str3) return "";
            i1 += gcd;
        }

        i1 = 0;
        while (i1 < str2.Length)
        {
            if (str2.Substring(i1, gcd) != str3) return "";
            i1 += gcd;
        }
        return str3;
    }

    public static int EuclideanGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}

