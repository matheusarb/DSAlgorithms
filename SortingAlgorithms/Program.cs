﻿Console.WriteLine("---------------SORTING ALGORITHMS----------------\n");
//----------------------DEFINITION-------------------------
//Given an array/collection of elements, rearrange them in ascending order or descending order
//1.    Comparison Based Sorting
//{ Selection Sort, Insertion Sort, Bubble Sort, Merge Sort, Quick Sort, Shell Sort, Heap Sort}
//2.    Index Based Sorting
//{ Count Sort, Bucket Sort, Radix Sort

int[] arr = new int[5] { 2, 4, 5, 1, 7 };
MybubbleSort(arr);

//1. ----------SELECTION SORT-----------
//Escolher o menor elemento na coleção e posicioná-lo no lugar apropriado (início). o mesmo procedimento será feito com todos os elementos

static void mySelectionSort(int[] arr)
{
    int i, j, min, temp;
    

}

//2. ----------BUBBLE SORT--------------
//IDEIA: Compara o index atual com o index seguinte; se for menor, trocam de lugar, senão segue para a próxima comparação (n0 comparar com n1, dps n1 com n2, n2 com n3...)
// são necessários dois forloops para 1) iterar sobre a array toda 2) e rodar a comparação de acordo com o tamanho da array



static void MybubbleSort(int[] arr)
{
    var length = arr.Length;
    int i, j, temp;
    for(i = 0; i < arr.Length; i++)
    {
        for(j = 0; j < arr.Length; j++)
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