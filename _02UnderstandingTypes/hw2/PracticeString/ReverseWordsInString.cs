namespace _02UnderstandingTypes.hw2.PracticeString;

public static class ReverseWordsInString
{
    public static void CompleteReverse(string str)
    {
        char[] charArray = str.ToCharArray();
        // List<int> IdxOfSpecialChars = new List<int>();
        // List<char> words = new List<char>();
        HashSet<char> set = new HashSet<char> { ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        int i = 0, j = charArray.Length - 1;
        string res = "";
        while (i < charArray.Length && j >= 0)
        {
            while (j >= 0 && set.Contains(charArray[j]))
            {
                res = charArray[j] + res;
                j--;
            }
            while (i < charArray.Length && !set.Contains(charArray[i]))
            {
                res = charArray[i] + res;
                i++;
            }
            while (j >= 0 && !set.Contains(charArray[j]))
            {
                j--;
            }
            while (i < charArray.Length && set.Contains(charArray[i]))
            {
                i++;
            }
        }
        Console.WriteLine(res);
    }
    
    public static void Run(string str)
    {
        char[] charArray = str.ToCharArray();
        // List<int> IdxOfSpecialChars = new List<int>();
        // List<char> words = new List<char>();
        HashSet<char> set = new HashSet<char> { ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        int i = 0, j = charArray.Length - 1;
        string res = "", tmp = "";
        while (i < charArray.Length && j >= 0)
        {
            while (j >= 0 && set.Contains(charArray[j]))
            {
                res = charArray[j] + res;
                j--;
            }
            while (i < charArray.Length && !set.Contains(charArray[i]))
            {
                tmp += charArray[i];
                i++;
            }
            res = tmp + res;
            while (j >= 0 && !set.Contains(charArray[j]))
            {
                j--;
            }
            while (i < charArray.Length && set.Contains(charArray[i]))
            {
                i++;
            }

            tmp = "";
        }
        Console.WriteLine(res);
    }
}