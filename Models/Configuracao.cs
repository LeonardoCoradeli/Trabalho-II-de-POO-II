using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Trabalho_II_de_POO_II.GUI;
using Trabalho_II_de_POO_II.Models;

public sealed class Arquivos
{
    private static Arquivos instance;
    private static readonly object padlock = new object();
    private string caminhoArquivoJogo = "listaJogos.bin";
    private string caminhoArquivoDesenvolvedora = "listaDesenvolvedoras.bin";
    private string caminhoArquivotransportadora = "listaTransportadoras.bin";
    private string caminhoArquivoCliente = "listaClientes.bin";
    private string caminhoArquivoGerente = "listaGerentes.bin";
    private string caminhoArquivoVenda = "listaVenda.bin";

    private Arquivos() { }

    public static Arquivos Instance
    {
        get
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Arquivos();
                    }
                }
            }
            return instance;
        }
    }

    public void SalvarJogos(List<Jogo> listaJogos)
    {
        SalvarLista(listaJogos, caminhoArquivoJogo);
    }

    public List<Jogo> RecuperarJogos()
    {
        return RecuperarLista<Jogo>(caminhoArquivoJogo);
    }

    public void SalvarDesenvolvedoras(List<Desenvolvedora> listaDesenvolvedoras)
    {
        SalvarLista(listaDesenvolvedoras, caminhoArquivoDesenvolvedora);
    }

    public List<Desenvolvedora> RecuperarDesenvolvedora()
    {
        return RecuperarLista<Desenvolvedora>(caminhoArquivoDesenvolvedora);
    }

    public void SalvarTransportadoras(List<Transportadora> listaTransportadoras)
    {
        SalvarLista(listaTransportadoras, caminhoArquivotransportadora);
    }

    public List<Transportadora> RecuperarTransportadoras()
    {
        return RecuperarLista<Transportadora>(caminhoArquivotransportadora);
    }

    public void SalvarVendas(List<Venda> listaVendas)
    {
        SalvarLista(listaVendas, caminhoArquivoVenda);
    }

    public List<Venda> RecuperarVendas()
    {
        return RecuperarLista<Venda>(caminhoArquivoVenda);
    }

    public void SalvarClientes(List<Usuario> listaClientes)
    {
        SalvarLista(listaClientes, caminhoArquivoCliente);
    }

    public List<Usuario> RecuperarClientes()
    {
        return RecuperarLista<Usuario>(caminhoArquivoCliente);
    }

    public void SalvarGerentes(List<Usuario> listaGerentes)
    {
        SalvarLista(listaGerentes, caminhoArquivoGerente);
    }

    public List<Usuario> RecuperarGerentes()
    {
        return RecuperarLista<Usuario>(caminhoArquivoGerente);
    }


    private void SalvarLista<T>(List<T> lista, string caminhoArquivo)
    {
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                formatter.Serialize(stream, lista);
            }

            Console.WriteLine($"Lista de {typeof(T).Name}s salva com sucesso no arquivo binário.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar a lista de {typeof(T).Name}s: {ex.Message}");
        }
    }

    private List<T> RecuperarLista<T>(string caminhoArquivo)
    {
        try
        {
            if (File.Exists(caminhoArquivo))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Open))
                {
                    List<T> lista = (List<T>)formatter.Deserialize(stream);
                    Console.WriteLine($"Lista de {typeof(T).Name}s recuperada com sucesso do arquivo binário.");
                    return lista;
                }
            }
            else
            {
                Console.WriteLine($"Arquivo binário de {typeof(T).Name}s não encontrado. Retornando uma lista vazia.");
                return new List<T>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao recuperar a lista de {typeof(T).Name}s: {ex.Message}");
            return new List<T>();
        }
    }

    public void SalvarDados(List<Jogo> jogos,List<Usuario> clientes, List<Usuario> gerentes, List<Venda> vendas, List<Desenvolvedora> desenvolvedoras, List<Transportadora> transportadoras)
    {
        SalvarJogos(jogos);
        SalvarClientes(clientes);
        SalvarGerentes(gerentes);
        SalvarVendas(vendas);
        SalvarDesenvolvedoras(desenvolvedoras);
        SalvarTransportadoras(transportadoras);
    }
}
