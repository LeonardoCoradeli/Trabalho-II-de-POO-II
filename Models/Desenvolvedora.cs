using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    [Serializable]
    public class Desenvolvedora
    {
        public int Codigo { get; protected set; }
        private string Cnpj { get; set; }
        public string Nome { get; private set; }
        private string Email { get; set; }
        private string Site { get; set; }
        private string RedeSocial { get; set; }
        private string Endereco { get; set; }

        public Desenvolvedora() { }

        public Desenvolvedora(int codigo,string cnpj, string nome, string email, string site, string redeSocial, string endereco)
        {
            Codigo = (codigo == -1)? NumAleatorio.Gerar<Desenvolvedora>() : codigo;
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
