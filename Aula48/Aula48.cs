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
    //5! = 5*4*3*2*1
    public int fat(int n){ //função recursiva, a função chama ela mesma
        int res;
        if(n<=1){
            res=1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }

}
class Aula48{
    static void Main(){

        Calc calc=new Calc();

        var res=calc.fat(10);

        Console.WriteLine(res);
    }
}