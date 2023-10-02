using System;
using System.Collections.Generic;

class Aula55{
    static void Main(){
        Dictionary <int,string> veiculos = new Dictionary<int, string>(); //é uma classe

        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        //veiculos.Clear(); ele limpa o dictionary

    veiculos.Remove(20);

        Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count); //count retorna um int
        int chave=20;
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} esta na coleca",chave);
        }else{
            Console.WriteLine("A chave{0} NAO esta na colecao",chave);
        }

        veiculos[15]="Bicicleta";

        string valor="Bicicleta";
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("O valor {0} esta na coleca",valor);
        }else{
            Console.WriteLine("O valor {0} NAO esta na colecao",valor);
        }

       Dictionary<int,string>.ValueCollection valores=veiculos.Values;
       
        foreach(string v in valores){
            Console.WriteLine(v);
        }
    }
}