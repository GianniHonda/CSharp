using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruído",nome);
    }

}

class Aula28{
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Théo");

        j1.energia=50;
        Console.WriteLine("Nome do jogador 1: {0}",j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}",j2.nome);
    }
        
}