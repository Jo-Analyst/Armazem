using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Departure
    {
        public int id { get; set; }
        public DateTime dateExit { get; set; }
        public string description { get; set; }
        public double quantity_exit { get; set; }
        public int storageId { get; set; }

        public void Save()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = id == 0 ? "INSERT INTO departures (date_exit, description, quantity_exit, storage_id) VALUES (@date_exit, @description, @quantity_exit, @storage_id);" : "UPDATE departures SET date_exit = @date_exit, description = @description, quantity_exit = @quantity_exit, storage_id = @storage_id WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("@date_exit", dateExit);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@quantity_exit", quantity_exit);
                    cmd.Parameters.AddWithValue("@storage_id", storageId);
                    cmd.ExecuteNonQuery();
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
                    string sql = "DELETE FROM Departures WHERE id = @id";
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

        public static DataTable FindByStorageId(int storageId, int page, int quantRows)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
                {
                    conn.Open();
                    string sql = $"SELECT id, DATE_FORMAT(date_exit, '%d/%m/%Y') as date, description, quantity_exit FROM departures WHERE storage_id = {storageId} ORDER BY date_exit DESC LIMIT {quantRows} OFFSET {page}";
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


        public static int CountQuantityDepartures(int departureId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = $"SELECT COUNT(*) FROM departures WHERE storage_id = {departureId} ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }

        public static int SumQuantityExit(int storageId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = $"SELECT SUM(quantity_exit) FROM departures WHERE storage_id = {storageId}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
