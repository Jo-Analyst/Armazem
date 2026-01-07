using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataBase
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Save()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = Id == 0 ? "INSERT INTO products (name) VALUES (@name); SELECT LAST_INSERT_ID()" : "UPDATE products SET name = @name WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.CommandText = sql;
                    if (Id == 0)
                        Id = Convert.ToInt32(cmd.ExecuteScalar());
                    else
                        cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable FindAll(int page, int quantRows)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM products ORDER BY name LIMIT {quantRows} OFFSET {page}";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);
                    DataTable dataTable = new DataTable();
                    cmd.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable FindByName(string name, int page, int quantRows)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM products WHERE name LIKE '%{name}%' ORDER BY name LIMIT {quantRows} OFFSET {page}";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(sql, conn);
                    DataTable dataTable = new DataTable();
                    cmd.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = "DELETE FROM products WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int CountQuantityProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }

        public static int CountQuantityProductsByName(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM products WHERE name LIKE @name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
    }
}
