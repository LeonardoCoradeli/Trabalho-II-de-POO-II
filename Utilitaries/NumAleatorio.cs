using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class NumAleatorio
{
    private static Dictionary<Type, List<int>> controleCodigo = new Dictionary<Type, List<int>>();
    private static string filePath = "numeros.txt";
    private static Random random = new Random();

    static NumAleatorio()
    {
        VerificarExistenciaDoArquivo();
        CarregarControleCodigo();
    }

    private static void VerificarExistenciaDoArquivo()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close(); // Cria o arquivo se não existir
        }
    }

    private static void CarregarControleCodigo()
    {
        try
        {
            var lines = File.ReadAllLines(filePath);
            controleCodigo = lines
                .Select(line => line.Split(':'))
                .Where(parts => parts.Length == 2) // Verifica se há duas partes na linha
                .ToDictionary(
                    parts => Type.GetType(parts[0]),
                    parts => parts[1].Split(',').Select(int.Parse).ToList()
                );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exceção ao carregar controle de códigos: {ex.Message}");
        }
    }

    public static int Gerar<T>() where T : class
    {
        Type tipoClasse = typeof(T);

        if (!controleCodigo.ContainsKey(tipoClasse))
        {
            controleCodigo[tipoClasse] = new List<int>();
        }

        int codigoEntidade = random.Next(0, 100);

        while (controleCodigo[tipoClasse].Contains(codigoEntidade))
        {
            codigoEntidade = random.Next(0, 100);
        }

        controleCodigo[tipoClasse].Add(codigoEntidade);
        AtualizarArquivo();
        return codigoEntidade;
    }

    private static void AtualizarArquivo()
    {
        var lines = controleCodigo
            .Select(pair => $"{pair.Key.FullName}:{string.Join(",", pair.Value)}")
            .ToArray();

        File.WriteAllLines(filePath, lines);
    }
}
