// // See https://aka.ms/new-console-template for more information
using _02UnderstandingTypes;
using System.Collections;
using _02UnderstandingTypes.hw2;
using _02UnderstandingTypes.hw2.PracticeString;

// ReadLine(), WriteLine(), Write()
CreateHackerName.GetHackerName();
//
//
// // 1. Practice number sizes and ranges:
// // Output the number of bytes in memory that each of the following types uses
// // Output the minimum and maximum
// // sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal
//
// // Size:
PracticeSizeAndRange.PrintSize();
// // maximum and minimum
PracticeSizeAndRange.PrintMaxAndMin();

//
// // // 2. Write a program: enter a integer number of centuries and convert it into years, days, hours, minutes, seconds
// // // milliseconds, microseconds, nanoseconds.
// ConvertCentury.Convert();
// // 1. What happens when you divide an int variable by 0?
// // throw an error: divide by zero
// // Console.WriteLine(1/0); 
//
// // // 2. What happens when you divide a double variable by 0?
// // return infinity
// Console.WriteLine(10.0/0); 
// // // 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
// // Console.WriteLine(int.MaxValue);
// // Cannot implicitly convert type 'long' to 'int'
// // int x = 21474836470; 
// //
// // 4. What is the difference between x = y++; and x = ++y;?
// int x, y = 0;
// x = y++; 
// Console.WriteLine($"x = {x}, y = {y}");
// //
// int a, b = 0;
// a = ++b;
// Console.WriteLine($"a = {a}, b = {b}");
// 5. What is the difference between break, continue, and return when used inside a loop statement?
// for (int i = 0; i < 10; i++)
// {
//     
//     if (i == 6)
//     {
//         break; // break will end the iteration and exit the loop immediately
//     }
//     Console.WriteLine(i);
// }
//
// for (int i = 0; i < 10; i++)
// {
//     
//     if (i == 6)
//     {
//         return; // return will exit the current method and return the specific values
//     }
//     Console.WriteLine(i);
// }
//
// for (int i = 0; i < 10; i++)
// {
//     
//     if (i == 6)
//     {
//         continue; // continue will skip the current iteration and move on to the next iteration
//     }
//     Console.WriteLine(i);
// }

// 6. What are the three parts of a for statement and which of them are required?
// initializer: initialize the loop control variable
// condition: required determine whether the loop should continue executing or not
// iterator: executed after each iteration

// 7. What is the difference between the = and == operators?
// =: assignment operator
// ==: equality operator check if the two variable' values or expression are the same

// 8. Does the following statement compile? for ( ; true; ) ;
// Yes, it creates infinite loop

// 9. What does the underscore _ represent in a switch expression?
// int number = 4;
//
// string result = number switch
// {
//     1 => "One",
//     2 => "Two",
//     3 => "Three",
//     _ => "Other" // '_' is used to discard the value for other cases
// };
// Console.WriteLine(result);

// What interface must an object implement to be enumerated over by using the foreach statement?
// IEnumerable<> interfaces, use GetEnumerator() method to get IEnumerator<> object
// then the IEnumerator object has two methods: MoveNext() and Reset(); 
// MoveNext() will advance to the next element
// Reset() will reset the IEnumerator to its initial state

// FizzBuzz is a group word game for children to teach them about division. Players take turns
// to count incrementally, replacing any number divisible by three with the word /fizz/, any
// number divisible by five with the word /buzz/, and any number divisible by both with /
// fizzbuzz/.
// Create a console application in Chapter03 named Exercise03 that outputs a simulated
// FizzBuzz game counting up to 100. The output should look something like the following
// screenshot:
FuzzBuzz.Start();


// Q: Create a console application and enter the preceding code. Run the console application and view the output. What happens?
// ANSWER: This program output the numbers from 0 to 255 over and over again. Since the condition of i < max is always true
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     Console.WriteLine(i);
// }

// Q: What code could you add (don’t change any of the preceding code) to warn us about the problem?
// CODE:
int max = 500;
for (byte i = 0; i < max; i++)
{
    if (i == byte.MaxValue)
    {
        Console.WriteLine("Warning: loop counter reach the maximum value for byte type");
        break;
    }
    Console.WriteLine(i);
}

// Question 1
// Your program can create a random number between 1 and 3 with the following code:
// int correctNumber = new Random().Next(3) + 1;
// Write a program that generates a random number between 1 and 3 and asks the user to
//     guess what the number is. Tell the user if they guess low, high, or get the correct answer.
//     Also, tell the user if their answer is outside of the range of numbers that are valid guesses
//     (less than 1 or more than 3). You can convert the user's typed answer from a string to an
// int using this code:
// int guessedNumber = int.Parse(Console.ReadLine());
// CODE:
GuessNumber.StartGame(1, 3, 5);

// Question 2
// Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
// will print the following pattern: If you find yourself getting stuck, try recreating the two
// examples that we just talked about in this chapter first. They’re simpler, and you can
// compare your results with the code included above.
// This can actually be a pretty challenging problem, so here is a hint to get you going. I used
// three total loops. One big one contains two smaller loops. The bigger loop goes from line
// to line. The first of the two inner loops prints the correct number of spaces, while the
// second inner loop prints out the correct number of stars.
Pyramid.PrintPyramid(30);

// Question 3 is the same as question 1

// Question 4
// Write a simple program that defines a variable representing a birth date and calculates
// how many days old the person with that birth date is currently.
// For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
// Note: once you figure out their age in days, you can calculate the days until the next
// anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .
// CODE:
AgeCalculator.CalculateAgeAndAnniversary(new DateTime(2000, 4, 7));
AgeCalculator.CalculateAgeAndAnniversary(new DateTime(2001, 4, 7));

//
// // Question 5
// // Write a program that greets the user using the appropriate greeting for the time of day.
// // Use only if , not else or switch , statements to do so. Be sure to include the following
// // greetings:
// // "Good Morning"
// // "Good Afternoon"
// // "Good Evening"
// // "Good Night"
// // It's up to you which times should serve as the starting and ending ranges for each of the
// // greetings. If you need a refresher on how to get the current time, see DateTime
// // Formatting. When testing your program, you'll probably want to use a DateTime variable
// // you define, rather than the current time. Once you're confident the program works
// // correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
// // assign DateTime.Now as its value, which is often a better approach)

// now
GreetByTime.Greeting(DateTime.Now);
// morning
DateTime morning = new DateTime(2024, 2, 20, 8, 0, 0);
GreetByTime.Greeting(morning);
// Afternoon
DateTime afternoon = new DateTime(2024, 2, 20, 14, 0, 0);
GreetByTime.Greeting(afternoon);
// Evening
DateTime evening = new DateTime(2024, 2, 20, 20, 0, 0);
GreetByTime.Greeting(evening);
// Evening
DateTime night = new DateTime(2024, 2, 20, 0, 0, 0);
GreetByTime.Greeting(night);

// // Question 6
// // Write a program that prints the result of counting up to 24 using four different increments.
// // First, count by 1s, then by 2s, by 3s, and finally by 4s.
// // Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
// // count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
// // loop control variable/ from the outer loop. This means the incrementing in the /
// // afterthought/ expression will be based on a variable.
// // Your output should look something like this:
// // 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
// // 0,2,4,6,8,10,12,14,16,18,20,22,24
// // 0,3,6,9,12,15,18,21,24
// // 0,4,8,12,16,20,24
CountInFourWays.Count();


ArrayList arr = new ArrayList();
arr.Add("string");
arr.Add(1);
foreach (var a in arr) {
    Console.WriteLine(a.GetType());
}


// Practice Arrays
// 1. Copying an Array
// Write code to create a copy of an array. First, start by creating an initial array. (You can use
// whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
// assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
// in the array.
// Now create a second array variable. Give it a new array with the same length as the first.
// Instead of using a number for this length, use the Lengthproperty to get the size of the
// original array.
// Use a loop to read values from the original array and place them in the new array. Also
// print out the contents of both arrays, to be sure everything copied correctly.

ArrayList firstArray = new ArrayList();
for (int i = 0; i < 10; i++)
{
    firstArray.Add(i);
}
ArrayList secondArray = new ArrayList();
for (int i = 0; i < firstArray.Count; i++)
{
    secondArray.Add(firstArray[i]);
}
Console.WriteLine($"{firstArray.ToArray()}, {secondArray.ToArray()}");

// 2. Write a simple program that lets the user manage a list of elements. It can be a grocery list,
// "to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
// implement an infinite loop. Each time through the loop, ask the user to perform an
// operation, and then show the current contents of their list. The operations available should
// be Add, Remove, and Clear. The syntax should be as follows:
// + some item
// - some item
// --
// Your program should read in the user's input and determine if it begins with a “+” or “-“ or
// if it is simply “—“ . In the first two cases, your program should add or remove the string
// given ("some item" in the example). If the user enters just “—“ then the program should
// clear the current list. Your program can start each iteration through its loop with the
// following instruction:
// CODE:
// AddOrRemoveByUser.Run();
// // 3. Write a method that calculates all prime numbers in given range and returns them as array
// // of integers
int[] primes =PrimeInGivenRange.FindPrimesInRange(1, 50);
Console.WriteLine(String.Join(", ", primes));

// 4. Write a program to read an array of n integers (space separated on a single line) and an
// integer k, rotate the array right k times and sum the obtained arrays after each rotation as
// shown below.
// After r rotations the element at position I goes to position (I + r) % n.
// The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1
RotateSum.Run();

// 5. Write a program that finds the longest sequence of equal elements in an array of integers.
// If several longest sequences exist, print the leftmost one.
FindLongestSequence.Run();

// 7. Write a program that finds the most frequent number in a given sequence of numbers. In
// case of multiple numbers with the same maximal frequency, print the leftmost of them
FIndMostFrequentNumber.Run();


// Practice String:
// 1. Write a program that reads a string from the console, reverses its letters and prints the
// result back at the console.
// Write in two ways
// Convert the string to char array, reverse it, then convert it to string again
// Print the letters of the string in back direction (from the last to the first) in a for-loop
string s1 = "sample";
ReverseString.Way1(s1);
ReverseString.Way2(s1);
string s2 = "24tvcoi92";
ReverseString.Way1(s2);
ReverseString.Way2(s2);

// 2. Write a program that reverses the words in a given sentence without changing the
// punctuation and spaces
// Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
// All other characters are considered part of words, e.g. C++, a+b, and a77 are
// considered valid words.
// The sentences always start by word and end by separator.
string str = "C# is not C++, and PHP is not Delphi!";
ReverseWordsInString.Run(str);
ReverseWordsInString.CompleteReverse(str);

// 3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
// and prints them on the console on a single line, separated by comma and space.Print all
// unique palindromes (no duplicates), sorted
string textPalindromes = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
TextAllPalindromes.Run(textPalindromes);

// 4. Write a program that parses an URL given in the following format:
// [protocol]://[server]/[resource]
// The parsing extracts its parts: protocol, server and resource.
// The [server] part is mandatory.
// The [protocol] and [resource] parts are optional.
string url1 = "https://www.apple.com/iphone";
ParseURL.Run(url1);
string url2 = "ftp://www.example.com/employee";
ParseURL.Run(url2);
string url3 = "https://google.com";
ParseURL.Run(url3);
