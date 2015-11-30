using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var juan = new Persona(5000.0);
            var ana = new Persona(6000.0);

            Console.WriteLine(juan + ana);

            Console.Read();
        }
    }
}
