using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public class SistemaJogosEletronicos
    {
        public string NomePlataforma { get; set; }
        public List<Venda> Vendas { get; set; }
        public List<Jogo> Jogos { get; set; }
        public List<Desenvolvedora> Desenvolvedoras { get; set; }
        public List<Transportadora> Transportadoras { get; set; }
        public List<Usuario> Clientes { get; set; }
        public List<Usuario> Gerentes { get; set; }
        public Configuracao Configuracoes { get; set; }

    }
}
