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

                // Combina o caminho relativo com o diretório do assembly
                string databasePath = Path.Combine(assemblyPath, "Models", "Banco.sqlite3");

                // Configura a conexão com o banco de dados SQLite usando o caminho relativo
                string connectionString = $"Data Source={databasePath};Version=3;";
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
            public void AddNewItem(string itemName)
            {
                string query = $"INSERT INTO MyTable (Name) VALUES ('{itemName}');";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
}
