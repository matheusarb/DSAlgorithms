// See https://aka.ms/new-console-template for more information
using OOP;
using System.Threading.Channels;

Console.WriteLine("OOP\n");

var peopleList = new List<Pessoa>();
var person1 = new Pessoa("bruce", 30);
var person2 = new Pessoa("peter", 20);
var person3 = new Pessoa("wolv", 25);
var person4 = new Pessoa("stacy", 22);
var person5 = new Pessoa("john", 34);
peopleList.Add(person1);
peopleList.Add(person2);
peopleList.Add(person3);
peopleList.Add(person4);
peopleList.Add(person5);

DisplayAgeByName(peopleList, "zé");

static void DisplayPeople(List<Pessoa> peopleList)
{
    foreach (var person in peopleList)
        Console.WriteLine($"{person.Nome}, {person.Idade} anos");
}

static void DisplayAgeByName(List<Pessoa> peopleList, string name)
{
    var contains = false;
    foreach (var pessoa in peopleList)
    {
        if (pessoa.Nome.ToLower() == name.ToLower())
        {
            Console.WriteLine($"Nome encontrado. O {name} possui {pessoa.Idade} anos");
            contains = true;
        }
    }

    if (contains is false)
    {
        Console.WriteLine("O nome informado não existe.");
    }
}