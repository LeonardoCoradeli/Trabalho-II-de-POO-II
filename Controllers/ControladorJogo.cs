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
        public sistemaJogosEletronicos.Vendas GetTodosJogos()
        {            
            sistemaJogosEletronicos.GetTodosJogos();
        }
        public sistemaJogosEletronicos.Jogos ListarJogosDeAcao(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarJogosDeAcao(jogos);
        }
        public sistemaJogosEletronicos.Jogos ListarJogosDeAventura(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarJogosDeAventura(jogos);
        }
        public sistemaJogosEletronicos.Jogos ListarJogosDeCorrida(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarJogosDeCorrida(jogos);
        }
        public sistemaJogosEletronicos.Jogos ListarJogosDeEsporte(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarJogosDeEsporte(jogos);
        }
        public sistemaJogosEletronicos.Jogos ListarJogosDeRPG(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarJogosDeRPG(jogos);
        }
        public sistemaJogosEletronicos.Jogos ListarTop10JogosMaisCaros(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarTop10JogosMaisCaros(jogos);
        }
        public sistemaJogosEletronicos.Jogos ListarTop10JogosMenorPreco(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarTop10JogosMenorPreco(jogos);
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao1(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarNomesOrdenadosPorAvaliacao1(jogos);
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao2(sistemaJogosEletronicos.Jogos jogos)
        {
            sistemaJogosEletronicos.ListarNomesOrdenadosPorAvaliacao2(jogos);
        }
    }
}
