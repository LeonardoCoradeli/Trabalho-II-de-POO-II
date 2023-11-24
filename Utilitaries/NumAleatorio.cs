using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trabalho_II_de_POO_II.Utilitaries
{
    public class NumAleatorio
    {
        public static List<int> controleCodigo = new List<int>();
        static string filePath = "numeros.txt";

        static NumAleatorio()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                controleCodigo = lines.Select(int.Parse).ToList();
            }
        }

        static int gerar()
        {
            Random random = new Random();
            int codigoJogo = random.Next(0, 1000);
            while (controleCodigo.Contains(codigoJogo))
            {
                codigoJogo = random.Next(0, 1000);
            }
            controleCodigo.Add(codigoJogo);
            File.AppendAllText(filePath, codigoJogo + Environment.NewLine);
            return codigoJogo;
        }
    }
}
