using System;

class Aula13
{
    static void Main()
    {
             int n1, n2, n3, n4, res;
        res=n1=n2=n3=n4=0;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;

        //>=60 Aprovado
        //59 e 40 recuperação
        //<40 reprovado

        if(res < 40)
        {
            resultado = "Reprovado";
        }else if(res < 60)
        {
            resultado = "Recuperação";
        }else 
        {
            resultado = "Aprovado";
        }
        Console.WriteLine("Nota: {0} - Resultado: {1}",res,resultado);
    }
}