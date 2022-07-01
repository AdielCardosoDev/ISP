namespace InfoSys
{
    internal class Conexao
    {
        public static string server = @"";
        public static string database = "";
        public static string user = "";
        public static string password = "";



        public static string StringConexao
        {
            get { return $"Data Source={server}; Integrated Security=false; Initial Catalog={database}; User ID={user}; Password={password}"; }
        }
    }
}
