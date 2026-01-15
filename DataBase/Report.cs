using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataBase
{
    public class Report
    {

        public string name { get; set; }
        public string date_storage { get; set; }
        public int stock { get; set; }
        public int quantity_exit { get; set; }
        public string description { get; set; }
        public string date_exit { get; set; }


        public static DataTable GetReport(string name, string dateEntry, int page = 0, int quantRows = 10)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = "";
                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id ORDER BY products.name LIMIT {quantRows} OFFSET {page}; ";
                else if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name, 
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE products.name LIKE '%{name}%' AND storages.date_storage = '{dateEntry}' ORDER BY products.name LIMIT {quantRows} OFFSET {page}; ";
                else if (!string.IsNullOrWhiteSpace(name))
                    sql = "SELECT" + $@"
                                products.name, 
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE products.name LIKE '%{name}%' ORDER BY products.name LIMIT {quantRows} OFFSET {page};";
                else if (!string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name, 
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE storages.date_storage = '{dateEntry}' ORDER BY products.name LIMIT {quantRows} OFFSET {page}; ";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable GetReportCompleted(string name, string dateEntry)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = "";
                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id; ";
                else if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name, 
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE products.name LIKE '%{name}%' AND storages.date_storage = '{dateEntry}'; ";
                else if (!string.IsNullOrWhiteSpace(name))
                    sql = "SELECT" + $@"
                                products.name, 
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE products.name LIKE '%{name}%';";
                else if (!string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name, 
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage, 
                                storages.stock, 
                                departures.quantity_exit,
                                departures.description,
                                DATE_FORMAT(departures.date_exit, '%d/%m/%Y') date_exit
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE storages.date_storage = '{dateEntry}'; ";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static int CountQuantityRows(string name, string dateEntry)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString.connectionChain))
            {
                conn.Open();
                string sql = null;
                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + @"
                                COUNT(products.id)
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id; ";
                else if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                COUNT(products.id)
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE products.name LIKE '%{name}%' AND storages.date_storage = '{dateEntry}'; ";
                else if (!string.IsNullOrWhiteSpace(name))
                    sql = "SELECT" + $@"
                               COUNT(products.id)
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE products.name LIKE '%{name}%';";
                else if (!string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                COUNT(products.id)
                    FROM products
                    inner JOIN storages ON storages.product_id = products.id
                    left JOIN departures ON departures.storage_id = storages.id WHERE storages.date_storage  = '{dateEntry}'; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
    }
}
