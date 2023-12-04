using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Trabalho_II_de_POO_II.GUI;
using System.Reflection;

namespace Trabalho_II_de_POO_II.Models
{ 
    public class AdaptadorBancoDados
    {
      public AdaptadorBancoDados()
        {

        }

        public (List<string>, List<object>) ConverterObjetoParaBanco(object obj)
        {
            var propriedades = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var nomesPropriedades = new List<string>();
            var valores = new List<object>();

            foreach (var prop in propriedades)
            {
                nomesPropriedades.Add(prop.Name);

                if (DeveExtrairCodigo(prop))
                {
                    valores.Add(ExtrairCodigo(prop.GetValue(obj)));
                }
                else
                {
                    valores.Add(LimparValor(prop.GetValue(obj)));
                }
            }

            return (nomesPropriedades, valores);
        }

        private string LimparValor(object valor)
        {
            // Lida com valores nulos
            if (valor == null)
            {
                return null;
            }

            // Trata valores de texto (escapa as aspas simples)
            if (valor is string)
            {
                return ((string)valor).Replace("'", "''");
            }

            return valor.ToString();
        }

        private bool DeveExtrairCodigo(PropertyInfo prop)
        {
            // Verifica se a propriedade é de uma das classes específicas e se o nome é 'codigo'
            return ((prop.PropertyType == typeof(Jogo) ||
                    prop.PropertyType == typeof(Pagamento) ||
                    prop.PropertyType == typeof(Venda) ||
                    prop.PropertyType == typeof(Desenvolvedora) ||
                    prop.PropertyType == typeof(Transportadora)) &&
                   prop.Name == "codigo");
        }

        private object ExtrairCodigo(object obj)
        {
            // Verifica se o objeto não é nulo e se tem uma propriedade chamada 'codigo'
            var codigoProp = obj.GetType().GetProperty("codigo", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            return codigoProp?.GetValue(obj);
        }



        public T ConverterBancoParaObjeto<T>(string dadosBd)
        {
            // Supondo que dadosBd seja uma string de pares chave=valor separados por vírgulas
            var paresChaveValor = dadosBd.Split(',');
            var resultado = Activator.CreateInstance<T>();
            foreach (var kvp in paresChaveValor)
            {
                var partes = kvp.Split('=');
                var prop = resultado.GetType().GetProperty(partes[0]);
                if (prop != null)
                {
                    prop.SetValue(resultado, Convert.ChangeType(partes[1], prop.PropertyType));
                }
            }
            return resultado;
        }
    }
}
