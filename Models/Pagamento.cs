using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public abstract class Pagamento
    {
        public int CodigoNota { get; set; }
        public Type Tipo { get; set; }

        public Pagamento() { }

        public Pagamento(int codigo,Type tipo)
        {
            CodigoNota = (codigo == -1)? NumAleatorio.Gerar<Pagamento>(): codigo;
            Tipo = tipo;
        }

        public abstract override string ToString();
    }
    public class Boleto : Pagamento
    {
        public string NumeroBoleto { get; set; }

        public Boleto() { }

        public Boleto(int codigo,string numero) : base(codigo,typeof(Boleto))
        {
            NumeroBoleto = numero;
        }

        public void GerarCodigoBoleto()
        {
            // Implement the logic to generate boleto code here
        }

        public override string ToString()
        {
            return $"Boleto: {NumeroBoleto}, CodigoNota: {CodigoNota}";
        }
    }
    public class CartaoCredito : Pagamento
    {
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }

        public CartaoCredito() { }

        public CartaoCredito(int codigo,string nome, string bandeira, string numero) : base(codigo,typeof(CartaoCredito))
        {
            Nome = nome;
            Bandeira = bandeira;
            NumeroCartao = numero;
        }

        public override string ToString()
        {
            return $"CartaoCredito: {Nome}, Bandeira: {Bandeira}, Numero: {NumeroCartao}, CodigoNota: {CodigoNota}";
        }
    }
    public class Pix : Pagamento
    {
        public string Nome { get; set; }
        public string CodigoPix { get; set; }

        public Pix() { }

        public Pix(int codigo,string nome, string codigoPix) : base(codigo,typeof(Pagamento))
        {
            Nome = nome;
            CodigoPix = codigoPix;
        }

        public void GerarCodigoPix()
        {
            // Implement the logic to generate Pix code here
        }

        public override string ToString()
        {
            return $"Pix: {Nome}, CodigoPix: {CodigoPix}, CodigoNota: {CodigoNota}";
        }
    }

}
