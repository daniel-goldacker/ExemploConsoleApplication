using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
   public  enum TipoSituacaoAluno
    {
        Reprovado,
        Recuperação,
        Aprovado
    }

    class Nota
    {
        public int IdAluno { get; set; }

        public double NotaAluno { get; set; }

        public TipoSituacaoAluno situacaoAluno(double mediaAluno)
        {
            TipoSituacaoAluno tipoSituacao;

            if (mediaAluno < 4)
                tipoSituacao = TipoSituacaoAluno.Reprovado;
            else if ((mediaAluno >= 4) & (mediaAluno < 7))
                tipoSituacao = TipoSituacaoAluno.Recuperação;
            else tipoSituacao = TipoSituacaoAluno.Aprovado;

            return tipoSituacao;
        }
    }
}
