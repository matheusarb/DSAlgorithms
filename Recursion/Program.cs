// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text;

Console.WriteLine("---------------RECURSION-----------------");

// Console.WriteLine(sumFac(5));
// factorialOfN(5);

//-------------------EXERCÍCIOS------------------
//1. Sum of n number
static void sumOfN(int n)
{
    var result = 0;
    var iterator = 1;
    do
    {
        result += iterator;
        iterator++;
        Console.WriteLine($"Resultado temporário é: {result}");
    } while (iterator <= n);
    Console.WriteLine($"Resultado é: {result}");
}

//1.1 Somar n números regressivamente
// somaRegressiva(5);
static void somaRegressiva(int n)
{
    int result, counter;
    result = 0;
    counter = 1;
    while (counter <= n)
    {
        result += counter;
        counter++;
        System.Console.WriteLine($"Resultado temporário {result}");
    }
    System.Console.WriteLine($"Result final {result}");
}

//1.2 Calcular fatorial
calcularFatorial(5);
static void calcularFatorial(int n)
{
    int result, counter;
    result = 1;
    counter = 1;
    while (counter <= n)
    {
        result *= counter;
        counter++;
        if(counter == n)
            System.Console.Write($" {result}\n");
        else
            System.Console.Write($" {result} *");
    }
    System.Console.WriteLine("resultado: " + result);
}

static int sumOfNRecursion(int n)
{
    Console.WriteLine("Resultado temporário é: " + n);
    if (n == 0)
        return 0;

    return sumOfNRecursion(n - 1) + n;
}

static int sumFac(int n)
{
    if (n == 0)
    {
        return 0;
    }
    System.Console.Write($"{n} ");
    return sumFac(n - 1) * n;
}

//2. Factorial of n number
static int factorialOfNRecursion(int n)
{
    if (n == 0)
        return 1;

    return factorialOfNRecursion(n - 1) * n;
}

static void factorialOfN(int n)
{
    var factorial = 1;
    for (var i = 1; i <= n; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine(factorial);
}

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
    if (n > 0)
    {
        Console.WriteLine(n);
        calcB(n - 1);
    }
}

static void calcB(int n)
{
    if (n > 0)
    {
        Console.WriteLine(n);
        calcA(n - 1);
    }
}

static void CalculateIterative(int n)
{
    while (n > 0)
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
        var k = n * n;
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