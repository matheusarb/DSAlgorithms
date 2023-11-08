// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("---------------RECURSION-----------------");

calcA(3);
//-------------------CONCEPTS--------------------
//1. A funciton that calls itself
//2. Needs at least one base case (condition to call itself)
//2.2. Needs to have an IF STATEMENT as the base case

//------------------TYPES OF RECURSION------------
//1. ----------Tail and Head Recursion
static void CalculateIterativeTailRecursion(int n)
{
    //needs a BASE CONDITION with an IF STATEMENT (MANDATORY)
     if (n > 0)
    {
        int k = n * n;
        Console.WriteLine(k);
        CalculateIterativeTailRecursion(n - 1); //tail recursion - a recursion call as the last statement of the base condition
    }
}
static void CalculateIterativeHeadRecursion(int n)
{
    //needs a BASE CONDITION with an IF STATEMENT (MANDATORY)
     if (n > 0)
    {
        CalculateIterativeHeadRecursion(n - 1); // head recursion - a recursion call as the first statement of the base condition
        int k = n * n;
        Console.WriteLine(k);
    }
}


//2. ----------Tree Recursion
//2.1when a method/function calls itself two times at the same base condition (if statement)
static void TreeRecursion(int n)
{
    //needs a BASE CONDITION with an IF STATEMENT (MANDATORY)
     if (n > 0)
    {
        CalculateIterativeHeadRecursion(n - 1);
        int k = n * n;
        Console.WriteLine(k);
        CalculateIterativeHeadRecursion(n - 1);
    }
}

//3. ----------Indirect Recursion
//3.1 separate functions calling each other in a given loop/circular pattern
//3.2 the function DOES NOT call itself. Instead, it calls other function
static void calcA(int n)
{
    if(n > 0)
    {
        Console.WriteLine(n);
        calcB(n - 1);
    }
}
static void calcB(int n)
{
    if(n > 0)
    {
        Console.WriteLine(n);
        calcA(n - 1);
    }
}


static void CalculateIterative(int n)
{
    while(n > 0)
    {
        int k = n * n;
        Console.WriteLine(k);
        n--;
    }
}
static void Calc(int n)
{
    if (n > 0)
    {
        var k = n*n;
        Console.WriteLine(k);
        Calc(n - 1);
    }
}
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