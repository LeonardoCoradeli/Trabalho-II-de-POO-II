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

        public Pagamento() { }

        public Pagamento(int codigoNota)
        {
            CodigoNota = codigoNota;
        }

        public abstract override string ToString();
    }
    public class Boleto : Pagamento
    {
        public string Numero { get; set; }

        public Boleto() { }

        public Boleto(int codigoNota, string numero) : base(codigoNota)
        {
            Numero = numero;
        }

        public void GerarCodigoBoleto()
        {
            // Implement the logic to generate boleto code here
        }

        public override string ToString()
        {
            return $"Boleto: {Numero}, CodigoNota: {CodigoNota}";
        }
    }
    public class CartaoCredito : Pagamento
    {
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public string Numero { get; set; }

        public CartaoCredito() { }

        public CartaoCredito(int codigoNota, string nome, string bandeira, string numero) : base(codigoNota)
        {
            Nome = nome;
            Bandeira = bandeira;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"CartaoCredito: {Nome}, Bandeira: {Bandeira}, Numero: {Numero}, CodigoNota: {CodigoNota}";
        }
    }
    public class Pix : Pagamento
    {
        public string Nome { get; set; }
        public string CodigoPix { get; set; }

        public Pix() { }

        public Pix(int codigoNota, string nome, string codigoPix) : base(codigoNota)
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
