using System;
using System.Collections.Generic;

class Aula56{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Navio");
        transp.AddFirst("Aviao");
        transp.AddFirst("Motocicleta"); //adiciona no início

        transp.AddLast("Bicicleta"); //adiciona no fim

        LinkedListNode<string>no;
        no=transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete"); //adiciona depois
        no=transp.FindLast("Carro");
        transp.AddBefore(no,"Patins"); //adiciona antes

        //transp.Clear();
        
        if(transp.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemnto encontrado");
        }

        //transp.Remove("Navio");
        transp.RemoveFirst(); //remove o primeiro elemento
        transp.RemoveLast(); //remove o ultimo elemento

        foreach(string t in transp){
            Console.WriteLine("Transporte:{0}",t);
        }
    }
}