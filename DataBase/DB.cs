using MySql.Data.MySqlClient;
using System;

namespace DataBase
{
    public class DB
    {
        static public bool IsConnect()
        {
            bool isConnect = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChainNoDatabase))
                {
                    conn.Open(); // tenta abrir a conexão

                    MySqlCommand cmd = new MySqlCommand("SELECT NOW();", conn);
                    object result = cmd.ExecuteScalar();
                    isConnect = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
            }

            return isConnect;
        }

        static public void CreateTables()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnString.connectionChain))
            {
                string sql = @"
                    CREATE TABLE IF NOT EXISTS products (
                        id int NOT NULL AUTO_INCREMENT,
                        name varchar(255) NOT NULL,
                        PRIMARY KEY (id)
                    );

                    CREATE TABLE IF NOT EXISTS storages (
                        id int NOT NULL AUTO_INCREMENT,
                        date_storage date NOT NULL,
                        stock double NOT NULL,
                        product_id int NOT NULL,
                        PRIMARY KEY (id),
                        KEY product_id_idx (product_id),
                        CONSTRAINT product_id FOREIGN KEY (product_id) REFERENCES  products  (id) ON DELETE CASCADE
                    );
                               
                    CREATE TABLE IF NOT EXISTS departures (
                        id int NOT NULL AUTO_INCREMENT,
                        description varchar(255) NOT NULL,
                        date_exit double NOT NULL,
                        storage_id int NOT NULL,
                        PRIMARY KEY (id),
                        KEY storage_id_idx (storage_id),
                        CONSTRAINT storage_id FOREIGN KEY (storage_id) REFERENCES storages ( id)  ON DELETE CASCADE
                    )";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.CommandText = sql;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        static public void CreateDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnString.connectionChainNoDatabase))
            {
                string sql = "CREATE DATABASE if NOT EXISTS armazem";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.CommandText = sql;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}