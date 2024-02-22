namespace _02UnderstandingTypes.hw2;

public static class FindLongestSequence
{
    public static void Run()
    {
        Console.WriteLine("press 1 to begin, 9 to exit. ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        while (choice != 9)
        {
            switch (choice)
            {
                case 1:
                    // get the input array
                    Console.Write("Input the array: ");
                    string[] numbers = Console.ReadLine().Split(",");
                    int[] arr = new int[numbers.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(numbers[i]);
                    }
                    int num = arr[0];
                    int maxOccurrence = 1;
                    int occurrence = 1;
                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (arr[i] != arr[i - 1])
                        {
                            if (maxOccurrence < occurrence)
                            {
                                num = arr[i-1];
                                maxOccurrence = occurrence;
                            }
                            occurrence = 1;
                        }
                        else
                        {
                            occurrence++;
                        }
                    }

                    if (occurrence > maxOccurrence)
                    {
                        maxOccurrence = occurrence;
                        num = arr[^1];
                    }

                    int[] res = Enumerable.Repeat(num, maxOccurrence).ToArray();
                    Console.WriteLine($"Longest Sequence Found: {string.Join(", ", res)}");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.WriteLine("press 1 to begin, 9 to exit. ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}