using System;
using System.Collections.Generic;

namespace Trabalho_II_de_POO_II.GUI
{
    public static class FactoryJogo
    {
        public static List<int> controleCodigo = new List<int>();

        static int gerar()
        {
            Random random = new Random();
            int codigoJogo = random.Next(0, 10);
            while (controleCodigo.Contains(codigoJogo))
            {
                codigoJogo = random.Next(0, 10);
            }
            controleCodigo.Add(codigoJogo);
            return codigoJogo;
        }

        public static Jogo CreateJogo(string tipo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requesitosminimos, float avaliacao, string comentarios, bool disponivel)
        {
            int retorno = gerar();
            switch (tipo)
            {
                case "Ação":
                    return new Acao(tipo, retorno, nome, descricao, desenvolvedora, dataLancamento, valor, requesitosminimos, avaliacao, comentarios, disponivel);
                case "Aventura":
                    return new Aventura(tipo, retorno, nome, descricao, desenvolvedora, dataLancamento, valor, requesitosminimos, avaliacao, comentarios, disponivel);
                case "RPG":
                    return new RPG(tipo, retorno, nome, descricao, desenvolvedora, dataLancamento, valor, requesitosminimos, avaliacao, comentarios, disponivel);
                case "Esporte":
                    return new Esporte(tipo, retorno, nome, descricao, desenvolvedora, dataLancamento, valor, requesitosminimos, avaliacao, comentarios, disponivel);
                case "Corrida":
                    return new Corrida(tipo, retorno, nome, descricao, desenvolvedora, dataLancamento, valor, requesitosminimos, avaliacao, comentarios, disponivel);
                default:
                    throw new ArgumentException("Tipo de jogo inválido");
            }
        }

    }
}
