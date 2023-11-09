// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------FIBONACCI---------\n");

fiboSequence2(5);


static bool fibonacciSequence1(int n)
{
    List<int> fibSeq = new List<int>();
    var n1 = 0;
    var n2 = 1;
    fibSeq.Add(n1);
    fibSeq.Add(n2);

    for (var i = 2; i < fibSeq.Count; i++)
    {
        fibSeq[i] = fibSeq[i - 1] + fibSeq[i - 2];
        i++;
        if (n == fibSeq[i])
        {
            return true;
        }
    }

    return false;
}

static void fiboSequence2(int n)
{
    List<int> arr = new() { };
    int n0 = 0;
    int n1 = 1;

    if (n > 0)
    {
        for (var  i = 2;  i < n; i++)
        {
            arr[i] = n0 + n1;
            n0 = n1;
            n1 = arr[i];            
        }
    }
    Exibir(arr);
}

static void Exibir(List<int> list)
{
    foreach (var item in list)
    {
        Console.Write(list[item]);
    }
}
