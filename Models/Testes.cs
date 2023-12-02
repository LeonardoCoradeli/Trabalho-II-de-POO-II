using System;
using Trabalho_II_de_POO_II.GUI;
using System.Collections.Generic;
using Trabalho_II_de_POO_II.Controllers;
using System.Windows.Documents;

namespace Trabalho_II_de_POO_II.Models
{
    class Testes
    {
        static void Main()
        {
            SistemaJogosEletronicos sistema = new SistemaJogosEletronicos(Arquivos.Instance);
            ControladorJogo controlador = new ControladorJogo(sistema);
            ControladorUsuario controlador2 = new ControladorUsuario(sistema);
            ControladorVendas controlador3 = new ControladorVendas(sistema);
            Tela_Principal tela = new Tela_Principal(controlador,controlador2,controlador3);
            tela.ShowDialog();
        }
    }
}
