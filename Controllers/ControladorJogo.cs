using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;
using Trabalho_II_de_POO_II.Models;

namespace Trabalho_II_de_POO_II.Controllers
{
    public class ControladorJogo
    {
        private SistemaJogosEletronicos sistemaJogosEletronicos;
        public ControladorJogo(SistemaJogosEletronicos sistemaJogosEletronicos)
        {
            this.sistemaJogosEletronicos = sistemaJogosEletronicos;
        }
        public void CadastrarJogo(string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, double valor, string requisitosMinimos, double avaliacao, string comentarios, bool disponivel, string tipo)
        {
            sistemaJogosEletronicos.CadastrarJogo(nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel, tipo);
        }
        public string buscarJogo(int codigo)
        {
            return sistemaJogosEletronicos.BuscarJogo(codigo);
        }
        public List<Jogo> GetTodosJogos()
        {            
            return sistemaJogosEletronicos.ListarTodosJogos();
        }
        public List<Jogo> ListarJogosPorTipo(List<Jogo> jogos, string tipo)
        {
            return sistemaJogosEletronicos.ListarJogosPorTipo(jogos, tipo);
        }
        public List<Jogo> ListarTop10JogosMaisCaros(List<Jogo> jogos)
        {
            return sistemaJogosEletronicos.ListarTop10JogosMaisCaros(jogos);
        }
        public List<Jogo> ListarTop10JogosMenorPreco(List<Jogo> jogos)
        {
            return sistemaJogosEletronicos.ListarTop10JogosMenorPreco(jogos);
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao1(List<Jogo> jogos)
        {
            return sistemaJogosEletronicos.ListarNomesOrdenadosPorAvaliacao1(jogos);
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao2(List<Jogo> jogos)
        {
            return sistemaJogosEletronicos.ListarNomesOrdenadosPorAvaliacao2(jogos);
        }
    }
}
