using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public class Transportadora
    {
        public int Codigo { get; set; }
        public string Cpnj { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int TempoDeEntrega { get; set; }

        public Transportadora() { }

        public Transportadora(int codigo, string cpnj, string nome, string email, string telefone, string endereco, int tempoDeEntrega)
        {
            Codigo = codigo;
            Cpnj = cpnj;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            TempoDeEntrega = tempoDeEntrega;
        }

        public override string ToString()
        {
            return $"Transportadora: {Nome}, CPNJ: {Cpnj}, Email: {Email}, Telefone: {Telefone}, Endereço: {Endereco}, Tempo de Entrega: {TempoDeEntrega}";
        }
    }
}
