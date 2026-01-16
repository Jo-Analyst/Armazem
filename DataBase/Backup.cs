

using MySql.Data.MySqlClient;

namespace DataBase
{
    public class Backup
    {
        public void GenerateBackup(string path)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"{ConnString.connectionChain} Convert Zero Datetime=True"))
                {
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {                 
                        using (MySqlBackup mb = new MySqlBackup(command))
                        {
                            connection.Open();
                            mb.ExportToFile(path);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public void RestoreDataBase(string path)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection($"{ConnString.connectionChain} Convert Zero Datetime=True"))
                {

                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        using (MySqlBackup mb = new MySqlBackup(command)) {
                            connection.Open();
                            mb.ImportFromFile(path);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
