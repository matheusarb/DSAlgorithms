// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------FIBONACCI---------\n");

//List<int> fiboSeq = new List<int>();
//int i = 1;
//while (i <= 50)
//{
//    // if (isFibo(i))
//    {
//        fiboSeq.Add(i);
//    }
//    i++;
//}

Exibir(fiboSeq(5));

static List<int> fiboSeq(int num)
{
    var fibonnaciSeq = new List<int>();

    if(num >= 1)
        fibonnaciSeq.Add(0);
    if(num >= 2)
        fibonnaciSeq.Add(1);

    for(int index = 2; index < num+5; index++)
    {
        int nextNum = fibonnaciSeq[index - 2] + fibonnaciSeq[index - 1];
        fibonnaciSeq.Add(nextNum);
    }

    return fibonnaciSeq;
}

// Create and check - WRONG
//static bool CreateAndCheck(int num)
//{
//    var fibo = new List<int>(num) { 0, 1 };

//    //if(num == 0 || num == 1 || num == 2)
//    //    return true;

//    for(var index=2; index <= num; index++)
//    {
//        int nextNum = fibo[index - 2] + fibo[index - 1];
//        fibo.Add(nextNum);
//    }
    
//    if(fibo.Contains(num))
//        return true;

//    return false;
//}

//fiboSequence2(5);
//ambas erradas eu acho
// static bool fibonacciSequence1(int n)
// {
//     List<int> fibSeq = new List<int>();
//     var n1 = 0;
//     var n2 = 1;
//     fibSeq.Add(n1);
//     fibSeq.Add(n2);

//     for (var i = 2; i < fibSeq.Count; i++)
//     {
//         fibSeq[i] = fibSeq[i - 1] + fibSeq[i - 2];
//         i++;
//         if (n == fibSeq[i])
//         {
//             return true;
//         }
//     }

//     return false;
// }

// static void fiboSequence2(int nthTerm)
// {
//     int n1 = 0;
//     int n2 = 1;
//     int nthNumber;

//         for(int i = 0; i < nthTerm; i++)
//         {
//             Console.Write(n1 + " ");
//             nthNumber = n1 + n2;
//             n1 = n2;
//             n2 = nthNumber;
//         }
// }

// //3a tentativa
// static bool isPerfSq(int n)
// {
//     var s = (int)Math.Sqrt(n);
//     return (s * s == n);
// }

// static bool isFibo(int n)
// {
//     return isPerfSq(5 * n * n + 4) || isPerfSq(5 * n * n - 4);
// }

static void Exibir(List<int> list)
{
    foreach (var item in list)
    {
        Console.Write(item + " ");
    }
}
