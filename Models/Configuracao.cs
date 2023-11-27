using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace Trabalho_II_de_POO_II.GUI
{

    public sealed class BancoDeDados
        {
            private static BancoDeDados instance;
            private static readonly object padlock = new object();
            private SQLiteConnection connection;

            private BancoDeDados()
            {
                InicializarBanco();
            }

            public static BancoDeDados Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new BancoDeDados();
                        }
                        return instance;
                    }
                }
            }

            private void InicializarBanco()
            {
                string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                Console.WriteLine(assemblyPath);

                // Combina o caminho relativo com o diretório do assembly
                //string databasePath = Path.Combine(Path.GetDirectoryName(assemblyPath), "Models", "Banco.sqlite3");


                // Configura a conexão com o banco de dados SQLite usando o caminho relativo
                string connectionString = $"Data Source=Banco.sqlite3";
                connection = new SQLiteConnection(connectionString);

                // Abrir a conexão
                connection.Open();

        }

            public SQLiteConnection GetConnection()
            {
                return connection;
            }

            // Método para excluir um item com base no código
            public void DeleteItem(int id)
            {
                string query = $"DELETE FROM MyTable WHERE ID = {id};";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Método para adicionar um novo item
            public void adicionar((string propiedades,string valores) ObjetoFormatado, string tabela)
            {
                try
                {
                    string query = $"INSERT INTO {tabela} ({ObjetoFormatado.propiedades} VALUES ({ObjetoFormatado.valores})";
                    using (SQLiteCommand comando = new SQLiteCommand(query, connection))
                    {
                        comando.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"Erro de SQL: {ex.Message}");
                }
                
            }
        }
}
