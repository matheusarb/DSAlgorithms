// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------HASH TABLES----------");

// Numa função Hash nós inserimos uma string e recebemos um número de volta, equivalente a string inserida
    // 1. Consistência. A mesma string inserida deverá retornar o mesmo númoer
    // 2. Deve mapear diferentes palavras para diferentes números
//Uma função hash funciona através da função Hash somada a uma array

// São úteis para:
    // 1.mapear algum item em relação a outro
    // 2.precisa pesquisar algo
    // 3. Utilizar como cache


Dictionary<string, decimal> estoqueMercado = new Dictionary<string, decimal>(){};
estoqueMercado.Add("Maca", 3.23m);

System.Console.WriteLine(estoqueMercado["Maca"]);

