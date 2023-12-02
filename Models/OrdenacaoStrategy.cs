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

                if (esquerda < tamanhoHeap && jogos[esquerda].Avaliacao.CompareTo(jogos[indice].Avaliacao) > 0)
                    maior = esquerda;
                else
                    maior = indice;

                if (direita < tamanhoHeap && jogos[direita].Avaliacao.CompareTo(jogos[maior].Avaliacao) > 0)
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
            QuickSort(jogos, 0, jogos.Count - 1);
            return jogos;
        }

        private void QuickSort(List<Jogo> jogos, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(jogos, low, high);
                QuickSort(jogos, low, pivotIndex - 1);
                QuickSort(jogos, pivotIndex + 1, high);
            }
        }

        private int Partition(List<Jogo> jogos, int low, int high)
        {
            Jogo pivot = jogos[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (jogos[j].Avaliacao.CompareTo(pivot.Avaliacao) < 0)
                {
                    i++;
                    Trocar(jogos, i, j);
                }
            }

            Trocar(jogos, i + 1, high);
            return i + 1;
        }

        private void Trocar(List<Jogo> jogos, int x, int y)
        {
            Jogo temp = jogos[x];
            jogos[x] = jogos[y];
            jogos[y] = temp;
        }
    }


}
