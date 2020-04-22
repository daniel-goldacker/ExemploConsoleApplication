using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Funcionario : Pessoa
    {

        public double salario { get; set; }
        public double percAumento { get; set; }

        private double calculaAumentoSalario(Double salario, Double percAumento)
        {
            return salario + ((salario * percAumento) / 100);
        }


        public void MostraFuncionario(Funcionario funcionario)
        {

            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine("* FUNCIONÁRIO ");
            Console.WriteLine("Nome: " + funcionario.nome);
            Console.WriteLine("Idade: " + pessoa.calculaIdade(funcionario.dataNascimento));
            Console.WriteLine("Salário Atual: " + funcionario.salario);
            Console.WriteLine("Aumento (%): " + funcionario.percAumento);
            Console.WriteLine("Salário Novo: " +  funcionario.calculaAumentoSalario(funcionario.salario, funcionario.percAumento));
        }
    }
}
