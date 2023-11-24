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
            while(controleCodigo.Contains(codigoJogo))
            {
                codigoJogo = random.Next(0, 10);
            }
            controleCodigo.Add(codigoJogo);
            return codigoJogo;
        }

        public static Jogo factoryMethod(string tipoJogo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel)
        {
            int codigoJogo = FactoryJogo.gerar();
            return null;
            // Implemente a lógica da fábrica aqui
            // Por exemplo:
            // switch (tipoJogo)
            // {
            //     case "SomeGameType":
            //         return new SomeGameType();
            //     default:
            //         return null;
            // }
        }

    }
}
