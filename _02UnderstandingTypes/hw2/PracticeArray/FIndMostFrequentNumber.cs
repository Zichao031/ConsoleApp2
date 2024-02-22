namespace _02UnderstandingTypes.hw2;

public static class FIndMostFrequentNumber
{
    public static void Run()
    {
        // get array from console:
        Console.Write("Input your array: ");
        string[] stringArray = Console.ReadLine().Split(',');
        int[] arr = stringArray.Select(int.Parse).ToArray();
        Console.WriteLine(string.Join(", ", arr));
        Dictionary<int, (int, int)> d = new Dictionary<int, (int, int)>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!d.TryAdd(arr[i], (1, i)))
            {
                (int count, _) = d[arr[i]];
                d[arr[i]] = (count + 1, i);
            }
                
        }

        int mostFrequent = 0;
        int num = 0;
        foreach (var kvp in d)
        {
            (int cnt, int i) = kvp.Value;
            if (cnt > mostFrequent)
            {
                num = kvp.Key;
                mostFrequent = cnt;
            }
        }
        Console.WriteLine($"Most Frequent element is {num}, frequency: {mostFrequent}");
    }
}