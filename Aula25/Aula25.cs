using System;
class Aula25{
    static void Main(){
        int num=50;
        dobrar1(ref num);
        Console.WriteLine(num);
    }

    static void dobrar1(ref int valor){
        valor*=2;
    }
    static void dobrar2(int valor){
        valor*=2;
    }
}