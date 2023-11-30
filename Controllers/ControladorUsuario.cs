﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

namespace Trabalho_II_de_POO_II.Controllers
{
    public class ControladorUsuario
    {
        private SistemaJogosEletronicos sistemaJogosEletronicos;
        public ControladorUsuario(SistemaJogosEletronicos sistemaJogosEletronicos)
        {
            this.sistemaJogosEletronicos = sistemaJogosEletronicos;
        }
        public void CadastrarCliente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, int nivel, bool clienteEpico)
        {
            sistemaJogosEletronicos.CadastrarCliente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataCadastro, nivel, clienteEpico);
        }
        public void CadastrarGerente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataAdmissao, double salario, string senha)
        {
            sistemaJogosEletronicos.CadastrarGerente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataAdmissao, salario, senha);
        }
        public void CadastrarDesenvolvedora(string nome, string cnpj, string endereco, string cep, string email, DateTime dataCadastro, string telefone)
        {
            sistemaJogosEletronicos.CadastrarDesenvolvedora(nome, cnpj, endereco, cep, email, dataCadastro, telefone);
        }
        public void CadastrarTransportadora(string nome, string cnpj, string endereco, string cep, string email, DateTime dataCadastro, string telefone)
        {
            sistemaJogosEletronicos.CadastrarTransportadora(nome, cnpj, endereco, cep, email, dataCadastro, telefone);
        }
        public void BuscarCliente(int codigo)
        {
            sistemaJogosEletronicos.BuscarCliente(codigo);
        }
        public void BuscarGerente(int codigo)
        {
            sistemaJogosEletronicos.BuscarGerente(codigo);
        }
        public void BuscarDesenvolvedora(int codigo)
        {
            sistemaJogosEletronicos.BuscarDesenvolvedora(codigo);
        }
        public void BuscarTransportadora(int codigo)
        {
            sistemaJogosEletronicos.BuscarTransportadora(codigo);
        }
        public void RemoverCliente(int codigo)
        {
            sistemaJogosEletronicos.RemoverCliente(codigo);
        }
        public void RemoverGerente(int codigo)
        {
            sistemaJogosEletronicos.RemoverGerente(codigo);
        }
        public void RemoverDesenvolvedora(int codigo)
        {
            sistemaJogosEletronicos.RemoverDesenvolvedora(codigo);
        }
        public void RemoverTransportadora(int codigo)
        {
            sistemaJogosEletronicos.RemoverTransportadora(codigo);
        }
        public void listarDesenvolvedoras()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasCadastradas();
        }
        public void listarDesenvolvedorasMaisVendidos()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasMaisVendidos();
        }
        public void ListarDesenvolvedorasComMaiorLucro()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasComMaiorLucro();
        }
        public void listarTransportadoras()
        {
            sistemaJogosEletronicos.ListarTodasTransportadoras();
        }
        public void listarGerentes()
        {
            sistemaJogosEletronicos.ListarGerentesCadastrados();
        }
        public void listarClientes()
        {
            sistemaJogosEletronicos.ListarClientesCadastrados();
        }
        public void listarClientesEpicos()
        {
            sistemaJogosEletronicos.ListarClientesEpicos();
        }
        public void listarTop10ClientesMaiorNivel()
        {
            sistemaJogosEletronicos.ListarTop10ClientesMaiorNivel();
        }
    }
}
