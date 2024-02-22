namespace _02UnderstandingTypes.hw2.PracticeString;

public static class ReverseString
{
    public static void Way1(string str)
    {
        char[] charArray = str.ToCharArray();
        string reversed = "";
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversed += charArray[i];
        }
        Console.WriteLine($"Way one result: {reversed}");
    }

    public static void Way2(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
    }
}