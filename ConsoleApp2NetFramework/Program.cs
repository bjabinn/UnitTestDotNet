using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2NetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new OperationManager();
            double valor1 = manager.RealizaOperacion(TipoOperacion.Suma, 4.0, 2.0);
            Console.WriteLine(valor1);

            var genderClient = new GenderAPIClient();
            var saludo = genderClient.GetGreetingByName("Jose").GetAwaiter().GetResult();
            Console.WriteLine(saludo);

            Console.ReadKey();
        }
    }
}
