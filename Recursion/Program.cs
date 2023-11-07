// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------RECURSION-----------------");

//-------------------CONCEPTS--------------------
//1. A funciton that calls itself
//2. Needs at least one base case (condition to call itself)

//calcular exponencial


CalculatePow(2, 5);
static void CalculatePow(int n, int pot)
{
    if (n > 0)
    {
        int result = n * n;
        int iterator = 1;
        
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
