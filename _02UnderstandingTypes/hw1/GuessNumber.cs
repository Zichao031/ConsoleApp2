namespace _02UnderstandingTypes;

public static class GuessNumber
{

    public static void StartGame(int min, int max, int guess=5)
    {
        Console.WriteLine($"Guess Game starts now! Are you ready?! I will generate a number between {min} and {max} inclusively.");
        int randomNumber = new Random().Next(min, max+1);
        Console.WriteLine(randomNumber);
        Console.Write("I have generated the number, guess what is the number: ");
        int num = GetUserInput();
        while (num != randomNumber && guess > 0)
        {
            if (num > randomNumber && num <= max)
            {
                Console.Write("OH TOO HIGH BRO, try again: ");
            }
            else if (num < randomNumber && num >= min)
            {
                Console.Write("ooooh too low low low low, try again: ");
            }
            else
            {
                Console.Write("OUT OF RANGE, try again: ");
            }
            // new guess
            num = GetUserInput();
            guess--;
        }

        if (num == randomNumber)
        {
            Console.WriteLine("Congrats!");
            return;
        }
        Console.WriteLine("Run out of guess times. Better luck next time!");
    }
    
    public static int GetUserInput()
    {
        string number = Console.ReadLine();
        int num;
        if (int.TryParse(number, out var parsedValue))
        {
            num = parsedValue;
        }
        else
        {
            Console.WriteLine("Only numerical input are valid (MAD FACE)");
            num = int.MinValue;
        }

        return num;
    }
}

