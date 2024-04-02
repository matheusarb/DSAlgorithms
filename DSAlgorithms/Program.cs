// See https://aka.ms/new-console-template for more information
Console.WriteLine("DSAlgorithms no code here");

// Binary Search is faster than simple search

var list = new List<int> { 1, 3, 5, 7, 9, 11 };
binarySearch(list, 1);
static void binarySearch(List<int> list, int val)
{
    int min, max;
    int guess = 0;
    int middle = 0;

    min = 0;
    max = list.Count - 1;

    while (min <= max)
    {
        middle = (min + max) / 2;
        guess = list[middle];

        if (guess == val)
            break;
        if (guess > val)
            max = middle - 1;
        else
            min = middle + 1;
    }
    System.Console.WriteLine($"val {val} | position {middle} | guess {guess}");
}