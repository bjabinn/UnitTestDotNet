namespace ConsoleApp2NetFramework
{
    public class OperationManager
    {
        public double RealizaOperacion (TipoOperacion operacion, double valor1, double valor2)
        {
            switch (operacion)
            {
                case TipoOperacion.Suma:
                    return valor1 + valor2;
                case TipoOperacion.Resta:
                    return valor1 - valor2;
                case TipoOperacion.Multiplicacion:
                    return valor1 * valor2;
                case TipoOperacion.Division:
                    return valor1 / valor2;
                default:
                    return 0;
            }
        }
    }
}
