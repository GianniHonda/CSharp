using System;

abstract class Padrao
{
    //Obrigatorio
    public abstract void taxaEmprestimo(double valor);
    //Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor * taxa));
    }
}