using System.Text.RegularExpressions;

namespace _02UnderstandingTypes.hw2.PracticeString;

public static class TextAllPalindromes
{
    public static void Run(string str)
    {
        HashSet<string> palidromes = new HashSet<string>();
        string[] words = ExtractWords(str);
        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                palidromes.Add(word);
            }
        }

        List<string> sortedPalidromes = new List<string>(palidromes);
        sortedPalidromes.Sort();
        Console.WriteLine(string.Join(", ", sortedPalidromes));
    }
    private static string[] ExtractWords(string sentence)
    {
        // Define a regular expression pattern to match words containing only letters
        string pattern = @"\b[A-Za-z]+\b";

        // Use Regex.Matches to find all matches of the pattern in the sentence
        MatchCollection matches = Regex.Matches(sentence, pattern);

        // Extract the matched words from the MatchCollection
        string[] words = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            words[i] = matches[i].Value;
        }

        return words;
    }

    private static bool IsPalindrome(string str)
    {
        int i = 0, j = str.Length - 1;
        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}