
var answer = string.Empty;
do
{
    int userNumber;
    Console.Write("Enter a number: ");
    userNumber = int.Parse(Console.ReadLine());
    for (int i = userNumber; i >= 0; i--)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();

    for (int i = 0; i <= userNumber; i++)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine("");

    Console.Write("Would you like to continue (y/n)?");
    answer = Console.ReadLine().Trim();
} while (answer == "y" && answer != "n");
Console.WriteLine("Goodbye!");

