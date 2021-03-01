using System;

namespace SimpleMath
{
    public static class CustomMath
    {

        public static double Resta() 
        {
            double resultado;
            Console.WriteLine("ingrese primer valor");
            int valor1 = Console.Read();

            Console.WriteLine("ingrese segundo valor valor");
            int valor2 = Console.Read();


            resultado = valor1-valor2;




            return resultado;
        }
        
    }
}