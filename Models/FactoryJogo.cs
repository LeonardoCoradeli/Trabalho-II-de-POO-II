using System;
using System.Collections.Generic;

namespace Trabalho_II_de_POO_II.GUI
{
    public static class FactoryJogo
    {

        public static Jogo CreateJogo(int cod,string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, double valor, string requesitosminimos, double avaliacao, string comentarios, bool disponivel,string tipo)
        {
            //gera um código aleatório para cada jogo criado
            int codigo = (cod == -1)? NumAleatorio.Gerar<Jogo>(): cod;
            switch (tipo)
            {
                case "Ação":
                    return new Acao(codigo,nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel,tipo);
                case "Aventura":
                    return new Aventura(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, tipo);
                case "RPG":
                    return new RPG(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, tipo);
                case "Esporte":
                    return new Esporte(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, tipo);
                case "Corrida":
                    return new Corrida(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel,tipo);
                default:
                    throw new ArgumentException("Tipo de jogo inválido");
            }
        }

    }
}
