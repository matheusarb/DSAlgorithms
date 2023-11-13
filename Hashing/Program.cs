Console.WriteLine("----------- HASHING ------------\n");

// HASH FUNCTION: receives an input and generates a random pattern
// it's a one way function. Through the input we'll generate the hash number(which is the same) but never the other way around;
// fixed value of an output for the same input is called IDEMPOTENT

//Console.WriteLine(Recursive(5));

//static int[] randomico()
//{
//    var arr = new int[20];
//    var random = new Random();

//    for (var i = 0; i < 20; i++)
//    {
//        arr[i] = random.Next(0, 101);
//        if (arr[i] == 1)
//            arr[i] = 1000;
//        Console.WriteLine($"Posição {i} = {arr[i]}");
//    }
//    return arr;
//}