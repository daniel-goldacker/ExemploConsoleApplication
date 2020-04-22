using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Aluno
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public int geraID(List<Aluno> listaAlunos)
        {
            if (listaAlunos.Count() == 0)
            {
                return 1; 
            }
            else
            {
                return listaAlunos.Last().Id + 1;
            }
        }

        public int calculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.Month < dataNascimento.Month) idade--;
            return idade;

        }



    }
}
