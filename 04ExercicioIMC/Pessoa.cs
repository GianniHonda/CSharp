using System;

class Pessoa
{
    //Atributo nome
    public string nome;
    //Atributo de peso
    public double peso;
    //Atributo de altura
    public double altura;

    //Método para retornar IMC
    public double CalcularIMC()
    {
       return peso / (altura * altura);
    }
    //Método para retornar uma string dependendo do IMC
    public string RetornoIMC(double imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Acima do peso";
        else if (imc < 35)
            return "Obesidade I";
        else if (imc < 40)
            return "Obesidade II";
        else 
            return "Obesidade III";                    
    }
    //Mensagem
    public void Mensagem()
    {
        //Calcular IMC
        double calcularIMC = CalcularIMC();
        //Mostrar condição do IMC
        string verRetorno = RetornoIMC(calcularIMC);
        //Mensagem
        Console.WriteLine(nome+" tem peso "+peso+" Kg, e altura "+altura+", tem um IMC de "+calcularIMC+" estando, portanto, "+verRetorno);
        
    }
}