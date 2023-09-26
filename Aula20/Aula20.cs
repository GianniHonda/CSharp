using System;

class Aula19{
    static void Main(){

            int[] num = new int[10];

            int i = num.Length-1;
            while(i>0){
                num[i]=0;
                Console.WriteLine(num[i]);
                i--;
            }
            Console.WriteLine("Fim do loop");
            
}
}