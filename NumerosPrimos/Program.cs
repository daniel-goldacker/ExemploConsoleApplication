using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder numerosPrimos = new StringBuilder();

            Console.WriteLine("Informe um número para saber os primos até ele:");
            int numeroInformado = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numeroInformado; i++)
            {

                int xQtdRegistros = 0;

                for (int x = 1; x <=i; x++)
                {
                    if (i % x == 0) xQtdRegistros++;
                }

                if (xQtdRegistros == 2)
                {
                    if (numerosPrimos.Length != 0) numerosPrimos.Append(", ");
                    numerosPrimos.Append(i);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Os números primos de 1 á " + numeroInformado + " são: " + numerosPrimos);
            Console.ReadKey();

        }
    }
}
