using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataBase
{
    public class Storage
    {
        public int id { get; set; }
        public string dateStorage { get; set; }
        public double stock { get; set; }
        public int productId { get; set; }

        public void Save()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = id == 0 ? "INSERT INTO storages (date_storage, stock, product_id) VALUES (@date_storage, @stock, @product_id);" : "UPDATE storages SET date_storage = @date_storage, stock = @stock, product_id = @product_id  WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("@date_storage", dateStorage);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@product_id", productId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable FindByProductId(int productId, int page, int quantRows)
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = $"SELECT (SELECT SUM(quantity_exit) FROM departures WHERE departures.storage_id = storages.id) as total_exit, stock - (SELECT SUM(quantity_exit) FROM departures WHERE departures.storage_id = storages.id) AS balance, id, DATE_FORMAT(date_storage, '%d/%m/%Y') as date, stock, product_id FROM storages WHERE product_id = {productId} ORDER BY date_storage DESC LIMIT {quantRows} OFFSET {page}";
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

        public static int CountQuantityStorages(int productId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = $"SELECT COUNT(*) FROM Storages WHERE product_id = {productId} ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = "DELETE FROM storages WHERE id = @id";
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
    }
}
