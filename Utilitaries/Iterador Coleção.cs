using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.Utilitaries
{
    public class IteradorColecao : IEnumerator
    {
        private readonly IList<object> colecao;
        private int indiceAtual;

        public IteradorColecao(IList<object> colecao)
        {
            this.colecao = colecao;
            indiceAtual = -1;
        }

        public bool MoveNext()
        {
            indiceAtual++;
            return indiceAtual < colecao.Count;
        }

        public void Reset()
        {
            indiceAtual = -1;
        }

        public object Current
        {
            get
            {
                if (indiceAtual < 0 || indiceAtual >= colecao.Count)
                {
                    throw new InvalidOperationException();
                }

                return colecao[indiceAtual];
            }
        }
    }
}
