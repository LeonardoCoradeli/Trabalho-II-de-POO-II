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
        private readonly SQLiteConnection _conexaoSqlite;

        public AdaptadorBancoDados(string stringConexao)
        {
            _conexaoSqlite = new SQLiteConnection(stringConexao);
        }

        public string ConverterParaFormatoBancoDados(object obj)
        {
            var propriedades = obj.GetType().GetProperties();
            string resultado = string.Empty;
            foreach (var prop in propriedades)
            {
                resultado += $"{prop.Name}={prop.GetValue (obj)},";
            }
            return resultado.TrimEnd(',');
        }

        public T ConverterDeFormatoBancoDados<T>(string dadosBd)
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
