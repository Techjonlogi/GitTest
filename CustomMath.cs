namespace SimpleMath
{
    public static class CustomMath
    {
        public static string Echo(string value = "Default value")
        {
            return value;
        }
        public static int Potencia(int numeroBase, int potencia){
            int resultado = numeroBase;
            
            for(int i = 1; i < potencia; i++){
                resultado = resultado * numeroBase;
            }

            return resultado;
        }
    }
}