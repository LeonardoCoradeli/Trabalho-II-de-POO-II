using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public class Desenvolvedora
    {
        private int Codigo { get; set; }
        private string Cnpj { get; set; }
        public string Nome { get; private set; }
        private string Email { get; set; }
        private string Site { get; set; }
        private string RedeSocial { get; set; }
        private string Endereco { get; set; }

        public Desenvolvedora() { }

        public Desenvolvedora(string cnpj, string nome, string email, string site, string redeSocial, string endereco)
        {
            Codigo = NumAleatorio.Gerar<Desenvolvedora>();
            Cnpj = cnpj;
            Nome = nome;
            Email = email;
            Site = site;
            RedeSocial = redeSocial;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"Desenvolvedora: {Nome}, CNPJ: {Cnpj}, Email: {Email}, Site: {Site}, Rede Social: {RedeSocial}, Endereço: {Endereco}";
        }
    }
}
