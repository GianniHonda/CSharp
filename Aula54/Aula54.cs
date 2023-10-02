using System;

namespace Calc1{ //componente para organização, pode usar o mesmo nome de classe com namespace diferente
    class Area{
        public static float Quad(float bas, float alt){
            if(bas==0 || alt==0){
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
             return bas*alt;
        }
    }
}

namespace Calc2{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas==0 || alt==0){
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
             return bas*alt;
        }
    }
}
class Aula54{
    static void Main(){
        float area=0;

        try{
        area=Calc2.Area.Quad(10f,0f);
        Console.WriteLine("Área do quad.:{0}",area);
        }catch(Exception e){
            Console.WriteLine("ERRO{0}",e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }

    }
}