namespace _02UnderstandingTypes.hw2;

public static class PrimeInGivenRange
{
    private static bool IsPrime(int num)
    {
        if (num == 1)
            return false;
        
        for (int i = 2; i < (int)(Math.Pow(num, 0.5) + 1); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> arr = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i)) 
                arr.Add(i);
        }

        return arr.ToArray();
    }
}