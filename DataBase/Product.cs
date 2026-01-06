using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float stock { get; set; }

        public void Save()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO products (@name, @stock) ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FindAll()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionString))
            {
                conn.Open();
                Console.WriteLine("Conexão aberta com sucesso!");

                string sql = "SELECT * FROM products";
                MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                cmd.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
