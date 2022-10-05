var combination = 13579;
var userEntry = 0;
var attemptCount = 0;

var result = KeyPad();

if (result == true)
{
    Console.WriteLine("Welcome, Home.");
}
else
{
    Console.WriteLine("Warning! There were too many incorrect attempts.");
}

bool KeyPad()
{
    do
    {
        Console.Write("Enter the Key Code: ");
        userEntry = int.Parse(Console.ReadLine());
        attemptCount++;
        if (attemptCount >= 5)
        {
            return false;
        }
    } while (userEntry != combination);
    Console.WriteLine();
    
    return true;
}
