using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Ralf";
            obj.idade = 30;
            obj.mensagem();
        }
    }
}