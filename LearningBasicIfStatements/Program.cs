

//bool isComplete = false;

//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//}
//else
//{
//    Console.WriteLine("The statement was false.");
//}

using System.Threading.Channels;

Console.Write("What is your first name? ");
string? firstName = Console.ReadLine();

if (firstName?.ToLower() == "justin")
{
    Console.WriteLine("Hello, Mr. Spencer.");
}
else
{
    Console.WriteLine($"Hello, {firstName}.");
}
Console.WriteLine("End of program.");