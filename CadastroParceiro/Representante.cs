using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Representante : Pessoa
    {
      public double percComissao { get; set; }
      public double valorVendido { get; set; }

        private double calculaComissao(Double valorVendido, Double perComissao)
        {
            return valorVendido + ((valorVendido * perComissao) / 100);
        }


        public void MostraRepresentante(Representante representante)
        {

            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine("* REPRESENTANTE ");
            Console.WriteLine("Nome: " + representante.nome);
            Console.WriteLine("Idade: " + pessoa.calculaIdade(representante.dataNascimento));
            Console.WriteLine("Valor Vendido: " + representante.valorVendido);
            Console.WriteLine("Comissao (%): " + representante.percComissao);
            Console.WriteLine("Valor Receber: " + representante.calculaComissao(representante.valorVendido, representante.percComissao));
        }

    }
}
