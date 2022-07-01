namespace InfoSys
{
    internal class Conexao
    {
        public static string server = @"ADIELCARDOSO\ESTUDOS";
        public static string database = "DB_SysClient";
        public static string user = "sa";
        public static string password = "1234";



        public static string StringConexao
        {
            get { return $"Data Source={server}; Integrated Security=false; Initial Catalog={database}; User ID={user}; Password={password}"; }
        }
    }
}
