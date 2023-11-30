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
            List<Type> excessao = new List<Type> { typeof(Desenvolvedora), typeof(Cliente), typeof(Gerente), typeof(Transportadora)};

            foreach (var prop in propriedades)
            {
                nomesPropriedades.Add(prop.Name);
                var codigoProp = prop.PropertyType.GetProperty("Codigo", BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.NonPublic);
                if (excessao.Contains(prop.PropertyType))
                {
                    if (codigoProp != null)
                    {
                        valores.Add(codigoProp.GetValue(prop.GetValue(obj)));
                    }
                    else
                    {
                        valores.Add(-1);
                    }
                }
                else
                {
                    valores.Add(prop.GetValue(obj));
                }
            }

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
