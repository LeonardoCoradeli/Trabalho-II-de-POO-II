using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;
using Trabalho_II_de_POO_II.Models;

namespace Trabalho_II_de_POO_II.Controllers
{
    public static class ControladorJogo
    {
        public static SistemaJogosEletronicos SJE { get; set; }

        public static void CadastrarJogo(string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, double valor, string requisitosMinimos, double avaliacao, string comentarios, bool disponivel, string tipo)
        {
            SJE.CadastrarJogo(nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel, tipo);
        }
        public static string buscarJogo(int codigo)
        {
            return SJE.BuscarJogo(codigo);
        }
        public static List<Jogo> GetTodosJogos()
        {
            return SJE.ListarTodosJogos();
        }

        public static List<Jogo> GetJogosComprados()
        {
            List<Jogo> jogos = new List<Jogo>();
            foreach (Jogo jogo in SJE.ListarTodosJogos())
            {
                if (!jogo.Disponivel)
                {
                    jogos.Add(jogo);
                }
            }
            return jogos;
        }

        public static List<Jogo> GetJogosDisponiveis()
        {
            List<Jogo> jogos = new List<Jogo>();
            foreach (Jogo jogo in SJE.ListarTodosJogos())
            {
                if (jogo.Disponivel)
                {
                    jogos.Add(jogo);
                }
            }
            return jogos;
        }
        public static List<Jogo> ListarJogosPorTipo(List<Jogo> jogos, string tipo)
        {
            return SJE.ListarJogosPorTipo(jogos, tipo);
        }
        public static List<Jogo> ListarTop10JogosMaisCaros(List<Jogo> jogos)
        {
            return SJE.ListarTop10JogosMaisCaros(jogos);
        }
        public static List<Jogo> ListarTop10JogosMenorPreco(List<Jogo> jogos)
        {
            return SJE.ListarTop10JogosMenorPreco(jogos);
        }
        public static List<string> ListarNomesOrdenadosPorAvaliacao1(List<Jogo> jogos)
        {
            return SJE.ListarNomesOrdenadosPorAvaliacao1(jogos);
        }
        public static List<string> ListarNomesOrdenadosPorAvaliacao2(List<Jogo> jogos)
        {
            return SJE.ListarNomesOrdenadosPorAvaliacao2(jogos);
        }
    }
}
