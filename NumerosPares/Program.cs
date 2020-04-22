using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder numerosPares = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (numerosPares.Length != 0) numerosPares.Append(", ");
                    numerosPares.Append(i);
                }
            }

            Console.WriteLine("Os números pares de 1 á 100 são: " + numerosPares);
            Console.ReadKey();
        }
    }
}
