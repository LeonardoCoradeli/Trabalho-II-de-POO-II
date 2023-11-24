using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

namespace Trabalho_II_de_POO_II.Models
{
    public interface IOrdenacao
    {
        List<Jogo> Organizar(List<Jogo> jogos);
    }

    public class ContextoOrganizacao
    {
        private IOrdenacao _estrategia;

        public ContextoOrganizacao(IOrdenacao estrategia)
        {
            _estrategia = estrategia;
        }

        public List<Jogo> Organizar(List<Jogo> jogos)
        {
            return _estrategia.Organizar(jogos);
        }
    }

    public class MetodoOrganizacao1 : IOrdenacao
    {
        public List<Jogo> Organizar(List<Jogo> jogos)
        {
            int tamanhoHeap = jogos.Count;
            for (int p = (tamanhoHeap - 1) / 2; p >= 0; p--)
                MaxHeapify(jogos, tamanhoHeap, p);

            for (int i = jogos.Count - 1; i > 0; i--)
            {
                Trocar(jogos, i, 0);
                tamanhoHeap--;
                MaxHeapify(jogos, tamanhoHeap, 0);
            }
            return jogos;
        }

        private void MaxHeapify(List<Jogo> jogos, int tamanhoHeap, int indice)
        {
            int esquerda = (indice + 1) * 2 - 1;
            int direita = (indice + 1) * 2;
            int maior = 0;

            if (esquerda < tamanhoHeap && jogos[esquerda].Nome.CompareTo(jogos[indice].Nome) > 0)
                maior = esquerda;
            else
                maior = indice;

            if (direita < tamanhoHeap && jogos[direita].Nome.CompareTo(jogos[maior].Nome) > 0)
                maior = direita;

            if (maior != indice)
            {
                Trocar(jogos, indice, maior);
                MaxHeapify(jogos, tamanhoHeap, maior);
            }
        }

        private void Trocar(List<Jogo> jogos, int x, int y)
        {
            Jogo temp = jogos[x];
            jogos[x] = jogos[y];
            jogos[y] = temp;
        }
    }

    public class MetodoOrganizacao2 : IOrdenacao
    {
        public List<Jogo> Organizar(List<Jogo> jogos)
        {
            int tamanhoHeap = jogos.Count;
            for (int p = (tamanhoHeap - 1) / 2; p >= 0; p--)
                MaxHeapify(jogos, tamanhoHeap, p);

            for (int i = jogos.Count - 1; i > 0; i--)
            {
                Trocar(jogos, i, 0);
                tamanhoHeap--;
                MaxHeapify(jogos, tamanhoHeap, 0);
            }
            return jogos;
        }

        private void MaxHeapify(List<Jogo> jogos, int tamanhoHeap, int indice)
        {
            int esquerda = (indice + 1) * 2 - 1;
            int direita = (indice + 1) * 2;
            int maior = 0;

            if (esquerda < tamanhoHeap && jogos[esquerda].Avaliacao > jogos[indice].Avaliacao)
                maior = esquerda;
            else
                maior = indice;

            if (direita < tamanhoHeap && jogos[direita].Avaliacao > jogos[maior].Avaliacao)
                maior = direita;

            if (maior != indice)
            {
                Trocar(jogos, indice, maior);
                MaxHeapify(jogos, tamanhoHeap, maior);
            }
        }

        private void Trocar(List<Jogo> jogos, int x, int y)
        {
            Jogo temp = jogos[x];
            jogos[x] = jogos[y];
            jogos[y] = temp;
        }
    }
}
