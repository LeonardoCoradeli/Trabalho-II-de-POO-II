using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Trabalho_II_de_POO_II.Models
{ 
    public class AdaptadorBancoDados
    {

        public AdaptadorBancoDados()
        {
        }

        public (string, string) ConverterObjetoParaBanco(object obj)
        {
            var propriedades = obj.GetType().GetProperties();
            string nomesPropriedades = string.Empty;
            string valores = string.Empty;

            foreach (var prop in propriedades)
            {
                nomesPropriedades += $"{prop.Name},";
                valores += $"{prop.GetValue(obj)},";
            }

            nomesPropriedades = nomesPropriedades.TrimEnd(',');
            valores = valores.TrimEnd(',');

            return (nomesPropriedades, valores);
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
