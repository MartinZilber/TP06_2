using System.Data.SqlClient;
using Dapper;

namespace TP06_2
{
    static public class BD
    {
        private static string _connectionString { get; set; } = @"Server=DESKTOP-CV8MP7S\SQLEXPRESS;DataBase=Juego;Trusted_Connection=true;";
        
        public static string traerNombre()
        {
            string nombre;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "select Nombre from Usuario where nombre = 'Hola'";
                nombre = db.QueryFirstOrDefault<string>(sql);
            }
            return nombre;
        }

    }
}