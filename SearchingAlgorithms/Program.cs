// See https://aka.ms/new-console-template for more information
using SearchingAlgorithms;
using System.Security.AccessControl;

Console.WriteLine("-------------SEARCHING ALGORITHMS------------");
var arr1 = new int[] { 21, 34, 47, 84, 96, 120 };

var search = new BSRecursive();
var result = search.binarySearchRecursive(arr1, 120, 0, arr1.Length - 1);

//Console.WriteLine(result == -1 ? "O número não foi encontrado" : $"O número é: {result}");
//var result = BS_Recursion(arr1, 17, 0, arr1.Length - 1);

//------------------------- BINARY SEARCH -----------------------
// Função do curso
static int BinarySearch(int[] Arr, int ALength, int Key)
{
    //inicializar duas variáveis: var L para o primeiro index
    //var R para o último index. Duas variáveis para mapear o index

    var Left = 0;
    var Right = ALength - 1;

    //verificar se o L é menor ou igual que o R
    while(Left <= Right)
    {
        var middle = (Left + Right) / 2;
        if (Key == Arr[middle])
            return middle;
        else if (Key < Arr[middle])
            Right = middle - 1;
        else if (Key > Arr[middle])
            Left = middle + 1;
    }
    return -1;
}
// Minha função
static int MyBinarySearch(int[] arr, int value)
{
    var left = 0;
    var right = arr.Length - 1;

    while (left <= right)
    {
        var middle = (left + right) / 2;
        if (value == arr[middle])
        {
            return arr[middle];
        }
        else if (value < arr[middle])
        {
            right = middle - 1;
        }
        else if (value > arr[middle])
        {
            left = middle + 1;
        }
    }
    return -1;
}
//Usando recursão
static int BS_Recursion(int[] arr, int value, int lIndex, int rIndex)
{
    if (lIndex > rIndex)
        return -1;
    else
    {
        var middle = (lIndex + rIndex) / 2;
        if (value == arr[middle])
            return arr[middle];
        else if (value < arr[middle])
            return BS_Recursion(arr, value, lIndex, rIndex - 1);
        else if (value > arr[middle])
            return BS_Recursion(arr, value, lIndex + 1, rIndex);
    }
    return -1;
}

//-------------------------LINEAR SEACH--------------------------
//Linear Seach do curso
static int LinearSearch(int[] A, int ALength, int key)
{
    var index = 0;
    while (index < ALength)
    {
        if (A[index] == key)
            //return index; //achar o index
            return key; //achar o value
                        //return A[index]; //achar o value 2
        index++;
    }
    return -1;
}
//Minha LinearSearch
static void MinhaLinearSeach(int[] arr, int value)
{
    var index = 0;
    var found = false;
    while (index < arr.Length)
    {
        var valArr = arr[index];
        //Console.WriteLine($"Iteração com o valor {arr[index]}");
        if (arr[index] == value)
        {
            found = true;
            Console.WriteLine($"O valor procurado é: {value}");
            break;
        }
        index++;
    }
    if (!found)
        Console.WriteLine("Não existe o valor na array informada");
}

static void ExibirArray(int[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
}