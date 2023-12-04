using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_II_de_POO_II.Utilitaries
{
    class VerificarVazio
    {
        public static bool verificarVazio(List<object> campos)
        {
            foreach (var campo in campos)
            {
                if (campo == null)
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (campo is string && string.IsNullOrWhiteSpace(campo.ToString()))
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}