// See https://aka.ms/new-console-template for more information
Console.WriteLine("-------------SEARCHING ALGORITHMS------------");

var arr1 = new int[] { 84, 21, 47, 96, 34, 120 };

//foreach (var item in arr1)
//{
//    Console.Write(item+ " ");
//}

Console.WriteLine(LinearSearch(arr1, 6, 21));
MinhaLinearSeach(arr1, 21);

//Linear Seach do curso
static int LinearSearch(int[] A, int ALength, int key)
{
    var index = 0;
    while(index < ALength)
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
    while(index < arr.Length)
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