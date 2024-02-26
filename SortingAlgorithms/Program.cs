Console.WriteLine("---------------SORTING ALGORITHMS----------------\n");
//----------------------DEFINITION-------------------------
//Given an array/collection of elements, rearrange them in ascending order or descending order
//1.    Comparison Based Sorting
//{ Selection Sort, Insertion Sort, Bubble Sort, Merge Sort, Quick Sort, Shell Sort, Heap Sort}
//2.    Index Based Sorting
//{ Count Sort, Bucket Sort, Radix Sort

// LEGENDA
// TC - Time Complexity
// SC - Space Complexity

int[] arr2 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
int[] arr = { 40, 10, 20, 30, 50 };
//MySelSort(arr);


//1. ----------SELECTION SORT-----------
//T
//Encontrar o menor elemento na coleção e posicioná-lo no lugar apropriado (início). o mesmo procedimento será feito com todos os elementos

static void MySelSort(int[] arr)
{
    int minVal, temp;
    var length = arr.Length;

    for (var i = 0; i < length - 1; i++)
    {
        //minVal segura a posição atual da array do outer loop
        minVal = i;

        for (var j = i + 1; j < length; j++)
        {
            if (arr[j] < arr[minVal])
            {
                minVal = j;
            }
        }

        temp = arr[minVal];
        arr[minVal] = arr[i];
        arr[i] = temp;
    }

    Exibir(arr);
}

//2. ----------BUBBLE SORT--------------
// SC - O(1)
//IDEIA: Compara o index atual com o index seguinte; se for menor, trocam de lugar, senão segue para a próxima comparação (n0 comparar com n1, dps n1 com n2, n2 com n3...)
// são necessários dois forloops para 1) iterar sobre a array toda 2) e rodar a comparação de acordo com o tamanho da array
static void MyBubbleSort(int[] arr)
{
    int j, k, temp;
    var length = arr.Length;

    for (j = 0; j < length; j++)
    {
        for (k = 0; k < length - 1; k++)
        {
            if (arr[k] > arr[k + 1])
            {
                temp = arr[k];
                arr[k] = arr[k + 1];
                arr[k + 1] = temp;
            }
        }
    }

    Exibir(arr);
}

//3.----------INSERTION SORT-----------
// assumimos que o elemento da primeira posição do array está "ordenado"
// é útil para quando a lista já está quase organizada
static void InsertionSort(List<int> arr)
{
    for (var i = 0; i < arr.Count - 1; i++)
    {
        if (arr[i] < arr[0])
        {
            arr.Insert(0, arr[i]);
        }
        else
        {
            for (var j = i + 1; j < arr.Count - 1; j++)
            {

            }
        }
    }

}

static void MyInsertionSort(int[] arr)
{
    for (var i = 1; i < arr.Length; i++)
    {
        var key = arr[i];
        var flag = 0;

        for (var j = i - 1; j >= 0 && flag != 1;)
        {

        }
    }
}

static void Exibir(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
}