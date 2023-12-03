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
            ControladorUsuario.SJE = sistema;
            ControladorJogo.SJE = sistema;
            ControladorVendas.SJE = sistema;
            Tela_Principal tela = new Tela_Principal();
            tela.ShowDialog();
            Arquivos.Instance.SalvarDados(sistema.Jogos,sistema.Clientes,sistema.Gerentes,sistema.Vendas,sistema.Desenvolvedoras,sistema.Transportadoras);
        } 
    }
}
