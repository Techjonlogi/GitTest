namespace SimpleMath
{
    public static class CustomMath
    {
        public static int Potencia(int numeroBase, int potencia){
            int resultado = numeroBase;
            
            for(int i = 1; i < potencia; i++){
                resultado = resultado * numeroBase;
            }

            return resultado;
        }
    }
}