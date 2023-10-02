using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){
        //string[] vs={"Carro","Moto","Navio","Aviao"};
        Queue<string>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro"); //adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v="Aviao";
        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo "+v+" encontrado");
        }else{
            Console.WriteLine("Veiculo "+v+" nao esta na fila");
        }
        //veiculos.Clear();
        //Console.WriteLine("Primeiro veiculo "+veiculos.Dequeue());
        //Console.WriteLine("Primeiro veiculo "+veiculos.Dequeue());
        Console.WriteLine("Primeiro veiculo "+veiculos.Peek());
        /*foreach(string veic in veiculos){
            Console.WriteLine("Veiculo "+veic);
        }*/
        Console.WriteLine("Tamanho fila:"+veiculos.Count);

        while(veiculos.Count >0){
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho fila:"+veiculos.Count);
    }
}