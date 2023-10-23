using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFB_Academia
{
    internal class Globais
    {
        public static string versao="1.0";
        public static Boolean logado=false;
        public static int nivel=0; //0=Básico - 1=Gerente - 2=Master
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_academia";
        public static string caminhoBanco = caminho+@"\banco\";
        public static string caminhoFotos = caminho + @"\fotos\";

        /*
        tb_usuarios
        N_IDUSUARIO
        T_NOMEUSUARIO
        T_USERNAME
        T_SENHAUSUARIO
        T_STATUSUSUARIO
        N_NIVELUSUARIO
        */
    }
}
