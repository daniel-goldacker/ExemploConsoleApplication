using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 - Criar um Funcionário");
            Console.WriteLine("2 - Criar um Represenatnte");
            Console.WriteLine("Informe uma opção:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Funcionario funcionario = new Funcionario();
                    Console.Clear();
                    Console.WriteLine("Nome : ");
                    funcionario.nome = Console.ReadLine();

                    Console.WriteLine("Data Nascimento : ");
                    funcionario.dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    Console.WriteLine("Salário (R$) : ");
                    funcionario.salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Aumento (%) : ");
                    funcionario.percAumento = Convert.ToDouble(Console.ReadLine());

                    funcionario.MostraFuncionario(funcionario);
                    break;

                case 2:
                    Representante representante = new Representante();
                    Console.Clear();
                    Console.WriteLine("Nome : ");
                    representante.nome = Console.ReadLine();

                    Console.WriteLine("Data Nascimento : ");
                    representante.dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    Console.WriteLine("Comissão (%) : ");
                    representante.percComissao = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Valor venda (R$) : ");
                    representante.valorVendido = Convert.ToDouble(Console.ReadLine());

                    representante.MostraRepresentante(representante);
                    break;
            }


            Console.ReadKey();
        }
    }
}
