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
            List<object> camposVazios = new List<object>();
            foreach (var campo in campos)
            {
                if (campo == null || string.IsNullOrWhiteSpace(campo.ToString()))
                {
                    camposVazios.Add(campo);
                }
            }
            if (camposVazios.Count > 0)
            {

                MessageBox.Show("Preencha todos os campos corretamente", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
