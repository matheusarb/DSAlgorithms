// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------RECURSION-----------------");

//-------------------CONCEPTS--------------------
//1. A funciton that calls itself
//2. Needs at least one base case (condition to call itself)

//calcular exponencial


CalculatePow(4, 5);
static void CalculatePow(int n, int pot)
{
    if (n > 0)
    {
        var result = n * n;
        var iterator = 2;
        Console.WriteLine($"Temporary result is: {result}");

        do
        {
            result = result * n;
            iterator++;    
            Console.WriteLine($"Temporary result is: {result}");
        } while (iterator <= pot - 1);
        
        Console.WriteLine($"\nPower of {n} to the power of {pot} is: {result}");
    }
    else
    {
        Console.WriteLine("Power of zero is zero. Try with an integer.");
    }
}
