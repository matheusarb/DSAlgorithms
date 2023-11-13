Console.WriteLine("---------------SORTING ALGORITHMS----------------\n");
//----------------------DEFINITION-------------------------
//Given an array/collection of elements, rearrange them in ascending order or descending order
//1.    Comparison Based Sorting
//{ Selection Sort, Insertion Sort, Bubble Sort, Merge Sort, Quick Sort, Shell Sort, Heap Sort}
//2.    Index Based Sorting
//{ Count Sort, Bucket Sort, Radix Sort


//1. ----------SELECTION SORT-----------
//Escolher o menor elemento na coleção e posicioná-lo no lugar apropriado (início). o mesmo procedimento será feito com todos os elementos


//2. ----------BUBBLE SORT--------------
//IDEIA: Compara o index atual com o index seguinte; se for menor, trocam de lugar, senão segue para a próxima comparação (n0 comparar com n1, dps n1 com n2, n2 com n3...)
int[] arr = new int[5] {2, 4, 5, 1, 7};
MybubbleSort(arr);

static void MybubbleSort(int[] arr)
{
    var length = arr.Length;
    int i, j, temp;
    for(i = 0; i < arr.Length-1; i++)
    {
        for(j = 0; j < arr.Length-1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    Exibir(arr);
}

static void Exibir(int[] arr)
{
    foreach(int i in arr)
    {
        Console.Write(i+" ");
    }
}