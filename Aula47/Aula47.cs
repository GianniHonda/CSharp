using System;

class Calc{
    public int soma(params int[]n){
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
     public double soma(params double[]n){
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
}
class Aula47{
    static void Main(){

        Calc calc=new Calc();

        var res=calc.soma(1,5,10,35,5.1);

        Console.WriteLine(res);
    }
}