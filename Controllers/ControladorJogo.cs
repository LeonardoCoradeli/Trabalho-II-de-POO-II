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
        public void CadastrarJogo(string nome, string descricao, string genero, string classificacao, string plataforma, string desenvolvedora, string transportadora, double preco, DateTime dataLancamento, int quantidade)
        {
            sistemaJogosEletronicos.CadastrarJogo(nome, descricao, genero, classificacao, plataforma, desenvolvedora, transportadora, preco, dataLancamento, quantidade);
        }
        public void buscarJogo(int codigo)
        {
            sistemaJogosEletronicos.buscarJogo(codigo);
        }
        public void removerJogo(int codigo)
        {
            sistemaJogosEletronicos.removerJogo(codigo);
        }
        public List<Jogo> GetTodosJogos()
        {            
            return sistemaJogosEletronicos.GetTodosJogos();
        }
        public List<Jogo> ListarJogosDeAcao(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarJogosDeAcao(jogos);
        }
        public List<Jogo> ListarJogosDeAventura(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarJogosDeAventura(jogos);
        }
        public List<Jogo> ListarJogosDeCorrida(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarJogosDeCorrida(jogos);
        }
        public List<Jogo> ListarJogosDeEsporte(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarJogosDeEsporte(jogos);
        }
        public List<Jogo> ListarJogosDeRPG(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarJogosDeRPG(jogos);
        }
        public List<Jogo> ListarTop10JogosMaisCaros(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarTop10JogosMaisCaros(jogos);
        }
        public List<Jogo> ListarTop10JogosMenorPreco(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarTop10JogosMenorPreco(jogos);
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao1(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarNomesOrdenadosPorAvaliacao1(jogos);
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao2(sistemaJogosEletronicos.Jogos jogos)
        {
            return sistemaJogosEletronicos.ListarNomesOrdenadosPorAvaliacao2(jogos);
        }
    }
}
