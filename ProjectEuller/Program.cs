// See https://aka.ms/new-console-template for more information
using System.Text;

var msg = "Project Euller Challenges";
static string convertToHifen(string msg)
{
    var result = new StringBuilder();
    var length = msg.Length;
    var counter = 0;

    while(counter < length)
    {
        result.Append("-");
        counter++;
    }

    return result.ToString();
}
Console.WriteLine($"{msg}\n{convertToHifen(msg)}\n");

// 1. If we list all the natural numbers below 10 that are multiples of 3 or 5 we get 3, 5, 6 and 9 
// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000
System.Console.WriteLine(sumOfMultiplesOf3And5Below1000());
static int sumOfMultiplesOf3And5Below1000()
{
    var result = 0;
    var counter = 0;
    while(counter < 1000)
    {
        if(counter % 3 == 0 && counter % 5 == 0 )
        {
            result += counter;
            counter++;
            continue;
        }
        if(counter % 3 == 0)
        {
            result += counter;
        }
        if(counter % 5 == 0)
        {
            result += counter;
        }
        counter++;
    }
    return result;
}
