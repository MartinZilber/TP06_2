using System.Data.SqlClient;
using Dapper;
using TP06_2.Models;

namespace TP06_2
{
    static public class BD
    {
        private static string _connectionString { get; set; } = @"Server=DESKTOP-CV8MP7S\SQLEXPRESS;DataBase=Juego;Trusted_Connection=true;";
        public static List<Juego> traerListaJuegos()
        {
            List<Juego> juegos = new List<Juego>();
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "select * from Juego";
                juegos = db.Query<Juego>(sql).ToList();
            }
            return juegos;
        }
        public static List<Juego> traerJuegosEncontrados(string busqueda)
        {
            List<Juego> juegos = new List<Juego>();
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                busqueda = $"%{busqueda}%";
                string sql = "select * from Juego where Nombre COLLATE Latin1_General_CI_AI LIKE @pbusqueda OR Descripcion COLLATE Latin1_General_CI_AI LIKE @pbusqueda ORDER BY Nombre, Descripcion" ;
                juegos = db.Query<Juego>(sql, new {pbusqueda = busqueda}).ToList();
            }
            return juegos;
        }

    }
}