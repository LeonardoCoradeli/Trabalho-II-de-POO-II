using System;
using Trabalho_II_de_POO_II.GUI;
using System.Collections.Generic;

namespace Trabalho_II_de_POO_II.Models
{
    class Testes
    {
        static void Main()
        {
            Console.WriteLine("teste");
            Arquivos arquivo = Arquivos.Instance;

            Desenvolvedora desenvolvedora = new Desenvolvedora(-1,"aaaaaa","aaaaa","aaaaaaa","aaaaa","aaaaa","aaaaaa");
            DateTime data = DateTime.Now;
            List<Jogo> jogo= new List<Jogo>()
            {
                FactoryJogo.CreateJogo(-1,"GTA V","Jogo muito legal",desenvolvedora,data,120.0,	"Confia",4,"Joia",true,"Ação"),
                FactoryJogo.CreateJogo(-1,"GTA V","Jogo muito legal",desenvolvedora,data,120.0,	"Confia",4,"Joia",true,"Ação")
            };
        
            arquivo.SalvarJogos(jogo);
            
            List<Jogo> jogosrecuperados = arquivo.RecuperarJogos();
            Console.WriteLine("teste");
            foreach(Jogo j in jogosrecuperados)
            {
                Console.WriteLine(j.Codigo);
            }
        }
    }
}
