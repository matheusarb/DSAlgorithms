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

int[] arr = { 40, 10, 20, 30, 50 };
int[] arr2 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
//MySelSort(arr);
// selectionSort(arr2);

//1. ----------SELECTION SORT-----------
//T
//Encontrar o menor elemento na coleção e posicioná-lo no lugar apropriado (início). o mesmo procedimento será feito com todos os elementos
static void selectionSort(int[] arr)
{
    int minimumIndex, temp;
    var length = arr.Length - 1;

    for (var i = 0; i <= length; i++)
    {
        minimumIndex = i;
        for (var j = i + 1; j <= length; j++)
        {
            if (arr[j] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    Exibir(arr);
}

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

//4. ------------- QUICKSORT ------------
// Um algoritmo de organização otimizado, mais rápido do que o de seleção
// utiliza a técnica "Dividir para conquistar" e é um bom exemplo de programação elegante
// algoritmos DC são recursivos
// Descubra o caso-base, que deve ser o caso mais simples possível
// divida ou diminua o problema até que ele se torne o caso-base
// Velocidade depende do pivô escolhido
// Como executar o quicksort:
    // 1. particione o array em subarrays
        // 1.1. Escolha um elemento pivô (pode ser qualquer um do array)
        // 1.2. Depois divida os elementos restantes em dois arrays; um contendo os números menores que o pivô e o outro contendo os maiores
    // 2. Chame recursivamente a função para os outros dois arrays para ordená-los
    // 3. Juntes todos os arrays na ordem

int[] arr3 = { 1, 5, 2, 3, 7, 6 };
var arr4 = new List<int>{ 1, 5, 2, 3, 7, 6 };


quickSort(arr3, 0, arr3.Length - 1);
static int[] quickSort(int[] array, int leftIndex, int rightIndex)
{
    if(array.Length < 2)
        return array;

    // i e j serão os counters dos subarrays (menores, maiores)
    var i = leftIndex;
    var j = rightIndex;
    var pivot = array[leftIndex];
    
    while(i <= j)
    {
        while(array[i] < pivot)
            i++;
        while(array[j] > pivot)
            j--;
        
        if(i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }

    if(leftIndex < j)
        quickSort(array, leftIndex, j);
    if(i < rightIndex)
        quickSort(array, i, rightIndex);
    
    // Exibir(array);
    return array;
}

static void Exibir(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
}