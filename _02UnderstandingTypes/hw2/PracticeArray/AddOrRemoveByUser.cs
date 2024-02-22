namespace _02UnderstandingTypes.hw2;

public static class AddOrRemoveByUser
{
    public static void Run()
    {
        bool exit = false;
        int num = 0;
        while (!exit)
        {
            Console.Write("Enter command (+ item, - item, or -- to clear or 9 to exit)): ");
            string? command = Console.ReadLine();
            switch (command)
            {
                case "+":
                    num++;
                    break;
                case "-":
                    num--;
                    break;
                case "--":
                    num = 0;
                    break;
                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
            Console.WriteLine($"num = {num}");
        }
    }
}