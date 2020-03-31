using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(2);
            Console.WriteLine(cuadrado.ToString());
            Console.ReadKey();
        }
    }
}
