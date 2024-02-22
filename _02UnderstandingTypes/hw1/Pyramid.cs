namespace _02UnderstandingTypes;

public static class Pyramid
{

    public static void PrintPyramid(int level)
    {
        level *= 2;
        for (int i = 0; i < level; i+=2)
        {
            for (int j = 0; j < (level - i) / 2; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i+1; k++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < (level - i) / 2; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}