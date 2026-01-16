using DataBase.Properties;
namespace DataBase
{
    public static class ConnString
    {
        public static string connectionChain = $"server= {Settings.Default["server"]};user=root;database=armazem;password=abc123;";
        public static string connectionChainNoDatabase = $"server= {Settings.Default["server"]};user=root;password=abc123;";
    }
}
