var answer = string.Empty;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    answer = Console.ReadLine().Trim();
} while (answer == "y" && answer != "n");
Console.WriteLine("Goodbye!");