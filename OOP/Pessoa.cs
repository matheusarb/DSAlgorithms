using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

public class Pessoa
{
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; private set; }
    public int Idade { get; private set; }
}
