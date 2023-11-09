// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------FIBONACCI---------\n");

fiboSequence2(5);

//ambas erradas eu acho
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

static void fiboSequence2(int nthTerm)
{
    int n1 = 0;
    int n2 = 1;
    int nthNumber;

        for(int i = 0; i < nthTerm; i++)
        {
            Console.Write(n1 + " ");
            nthNumber = n1 + n2;
            n1 = n2;
            n2 = nthNumber;
        }
}

static void Exibir(List<int> list)
{
    foreach (var item in list)
    {
        Console.Write(list[item]+" ");
    }
}
