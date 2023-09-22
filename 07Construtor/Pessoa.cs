using System;

class Pessoa
{
    //construtor
    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá"+nome);
    }
}