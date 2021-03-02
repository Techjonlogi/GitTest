using System;

namespace SimpleMath
{
    public static class CustomMath
    {
 
        public static double Resta()
        {
            double resultado;
            Console.WriteLine("ingrese primer valor");
            int valor1 =Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese segundo valor valor");
            int valor2 = Int32.Parse(Console.ReadLine());


            resultado = valor1-valor2;




            return resultado;
        }
        
    }
}