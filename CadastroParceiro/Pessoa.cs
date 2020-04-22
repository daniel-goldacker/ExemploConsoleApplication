using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Pessoa
    {
        public string nome { get; set; }
        public DateTime dataNascimento { get; set;}


        public int calculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.Month < dataNascimento.Month) idade--;
            return idade;

        }
    } 
}
