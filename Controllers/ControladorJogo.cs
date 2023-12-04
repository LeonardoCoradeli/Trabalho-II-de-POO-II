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
        public static List<Jogo> ListarJogosPorTipo(string tipo)
        {
            return SJE.ListarJogosPorTipo(tipo);
        }
        public static List<Jogo> ListarTop10JogosMaisCaros()
        {
            return SJE.ListarTop10JogosMaisCaros();
        }
        public static List<Jogo> ListarTop10JogosMenorPreco()
        {
            return SJE.ListarTop10JogosMenorPreco();
        }
        public static List<Jogo> ListarNomesOrdenadosPorAvaliacao1()
        {
            return SJE.ListarNomesOrdenadosPorAvaliacao1();
        }
        public static List<Jogo> ListarNomesOrdenadosPorAvaliacao2()
        {
            return SJE.ListarNomesOrdenadosPorAvaliacao2();
        }
        public static void TornarJogoIndisponivel(int codigo)
        {
            SJE.tornarJogoIndisponivel(codigo);
        }
        public static void atualizarAvalicao(int codigo, int avaliacao)
        {
            SJE.atualizarAvalicao(codigo, avaliacao);
        }
        public static void atualizarComentarios(int codigo, string comentarios)
        {
            SJE.atualizarComentarios(codigo, comentarios);
        }
    }
}
