namespace _02UnderstandingTypes.hw2.PracticeString;

public static class ParseURL
{
    public static void Run(string url)
    {
        Uri uri = new Uri(url);
        string protocol = uri.Scheme;
        string server = uri.Host;
        string resource = uri.PathAndQuery.TrimStart('/');
        
        Console.WriteLine($"[Protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
        Console.WriteLine();
    }
}