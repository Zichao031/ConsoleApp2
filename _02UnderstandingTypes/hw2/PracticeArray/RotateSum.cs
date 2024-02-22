namespace _02UnderstandingTypes.hw2;

public static class RotateSum
{
    public static void Run()
    {
        // input array
        Console.Write("input the array for rotate: ");
        string? imputString = Console.ReadLine();
        string[] inputs = imputString.Split(' ');
        // input k
        Console.Write("input the times for rotate: ");
        int? k = Convert.ToInt32(Console.ReadLine());
        //
        int[] numbers = new int[inputs.Length];
        int[] sums = new int[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            numbers[i] = int.Parse(inputs[i]);
        }
        
        for (int r = 1; r <= k; r++)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int idx = (r + i) % numbers.Length;
                sums[idx] += numbers[i];
                Console.WriteLine($"i = {i}, num = {numbers[idx]}, sum = {sums[i]}");
            }
        }
        Console.WriteLine("Array elements: " + string.Join(" ", sums));
    }
}