// See https://aka.ms/new-console-template for more information
Console.WriteLine("---GRAFOS---\n");

//1. Um modelo de grafo é um conjunto de conexões
//1.1. Muito usado para pesquisa e descoberta do caminho mais curto do ponto A ao B
//2. É uma maneira de modelar como eventos diferentes estão conectados entre si
//2.1. São formados por vértices e arestas

//3. Pesquisas em largura
//3.1. A pesquisa irradia do ponto inicial. Analisará primeiro todas as conexões de 1º grau para, após, passar para os graus seguintes

//4. TEstes
// var mangoSellers = new Dictionary<string, bool>{
//     {"Alice", false},
//     {"Bob", false},
//     {"Claire", true}
// };

// foreach(var person in mangoSellers)
// {
//     if(!person.Value)
//         mangoSellers.Remove(person.Key);
// }

// Exibir(mangoSellers);

//5. Algoritmo de Grafo
var grafoPessoas = new Dictionary<string, string[]>
{
    { "matheus", new string[] { "luiggi", "xande", "tata" } },
    { "bob", new string[] { "anuj", "peg" } }
};

var queue = new Queue<Dictionary<string, string[]>>();
queue.Enqueue(grafoPessoas);
Exibir2(queue);

static void Exibir2(Queue<Dictionary<string, string[]>> queue)
{
    foreach (var grafo in queue)
    {
        foreach(var dict in grafo)
        {
            foreach(var item in dict.Value)
            {
                System.Console.WriteLine($"Lista de amigos de {dict.Key} || {item} ");
            }
        }
    }
}

static void Exibir(Dictionary<string, bool> dict)
{
    foreach (var item in dict)
        System.Console.WriteLine($"{item.Key} | {item.Value}");
}