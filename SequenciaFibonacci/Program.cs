using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

           int numeroAnterior = 0;
           int numeroAtual = 1;
           int seqFibonacci = 0;
           
           for(int i = 1; seqFibonacci <= 100000; i++)
            {
                Console.WriteLine(seqFibonacci);
                seqFibonacci = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = seqFibonacci;
            }
            Console.ReadKey();
        }
    }
}




