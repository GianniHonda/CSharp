using System;

class Pessoa
{
    //atributos
    public string nome;
    public int idade;

    //métodos
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos.");
    }
}