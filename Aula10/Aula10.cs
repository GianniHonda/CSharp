using System;

class Aula10
{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main()
    {
        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}