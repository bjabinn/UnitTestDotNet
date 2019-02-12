using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new OperationManager();
            double valor1 = manager.RealizaOperacion(TipoOperacion.Suma, 4.0, 2.0);
            Console.WriteLine(valor1);
            Console.ReadKey();
        }
    }

    
}
