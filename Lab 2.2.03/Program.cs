
//step 1
//var combination = 13579;
//var userEntry = 0;

//while (userEntry != combination)
//{
//    Console.Write("Enter the Key Code: ");
//    userEntry = int.Parse(Console.ReadLine());
//}
//Console.WriteLine();
//Console.WriteLine("Welcome, Home.");


//step 2
var combination = 13579;
var userEntry = 0;
var attemptCount = 0;

while (userEntry != combination)
{
    Console.Write("Enter the Key Code: ");
    userEntry = int.Parse(Console.ReadLine());
    attemptCount++;
    if (attemptCount >= 5)
    {
        Console.WriteLine("Warning! There were too many incorrect attempts.");
        return;
    }
}
Console.WriteLine();
Console.WriteLine("Welcome, Home.");