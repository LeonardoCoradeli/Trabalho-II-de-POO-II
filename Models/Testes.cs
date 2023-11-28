using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

namespace Trabalho_II_de_POO_II.Models
{
    class Testes
    {
        static void Main()
        {
            BancoDeDados banco = BancoDeDados.Instance;
            AdaptadorBancoDados adaptador = new AdaptadorBancoDados();
            
            Desenvolvedora dessenvolvedora = new Desenvolvedora("aaaaaaaa", "aaaaaaa", "aaaaaaa", "aaaaaaa", "aaaaaaa", "aaaaaaa");
            DateTime dateTime = DateTime.Now;

            IJogo jogo = FactoryJogo.CreateJogo("Ação", "GTA V","Jogo muito legal",dessenvolvedora,dateTime,120.00,"Confia",4.0,"Joia",true);

            //(string propiedades, string valores) = adaptador.ConverterObjetoParaBanco(jogo);

            //Console.WriteLine(propiedades);
            //Console.WriteLine(valores);
            banco.Adicionar(adaptador.ConverterObjetoParaBanco(dessenvolvedora), "Desenvolvedora");
            banco.Adicionar(adaptador.ConverterObjetoParaBanco(jogo),"Jogos");

        }
    }
}
