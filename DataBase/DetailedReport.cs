using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataBase
{
    public class DetailedReport
    {  
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
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0
                           ORDER BY products.name LIMIT {quantRows} OFFSET {page}; ";
                else if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                  products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage,
                                storages.stock,
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           WHERE products.name LIKE '%{name}%' AND storages.date_storage = '{dateEntry}' 
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0
                           ORDER BY products.name LIMIT {quantRows} OFFSET {page}; ";
                else if (!string.IsNullOrWhiteSpace(name))
                    sql = "SELECT" + $@"
                              products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage,
                                storages.stock,
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           WHERE products.name LIKE '%{name}%' 
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0
                           ORDER BY products.name LIMIT {quantRows} OFFSET {page};";
                else if (!string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                           products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage,
                                storages.stock,
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           WHERE storages.date_storage = '{dateEntry}' 
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0
                           ORDER BY products.name LIMIT {quantRows} OFFSET {page}; ";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable GetDetailedReportCompleted(string name, string dateEntry)
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
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0";
                else if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                           products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage,
                                storages.stock,
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           WHERE products.name LIKE '%{name}%' AND storages.date_storage = '{dateEntry}'; 
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0";
                else if (!string.IsNullOrWhiteSpace(name))
                    sql = "SELECT" + $@"
                                products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage,
                                storages.stock,
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           WHERE products.name LIKE '%{name}%';
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0 
";
                else if (!string.IsNullOrEmpty(dateEntry))
                    sql = "SELECT" + $@"
                                products.name,
                                DATE_FORMAT(storages.date_storage, '%d/%m/%Y') AS date_storage,
                                storages.stock,
                                SUM(departures.quantity_exit) AS total_exit,
	                            (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) AS balance
                           FROM products
                           INNER JOIN storages 
                               ON storages.product_id = products.id
                           INNER JOIN departures 
                               ON departures.storage_id = storages.id
                           WHERE storages.date_storage = '{dateEntry}'; 
                           GROUP BY 
                               products.name,
                               storages.date_storage,
                               storages.stock
                           HAVING (storages.stock - SUM(IFNULL(departures.quantity_exit, 0))) > 0";

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
