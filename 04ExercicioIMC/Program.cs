using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Instanciar objeto da classe Pessoa
           Pessoa a = new Pessoa();
           a.nome = "Gianni";
           a.peso = 70;
           a.altura = 1.64;
           a.Mensagem();
        }
    }
}