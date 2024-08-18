using System.Data.SqlClient;
using Dapper;
namespace TP06_2.Models
{
    public class Juego
    { 
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Imagen{get;set;}
        public string Descripcion{get;set;}
        
        public Juego()
        {

        }
        public Juego(int id, string nombre, string imagen, string descripcion)
        {
            Id = id;
            Nombre= nombre;
            Imagen = imagen;
            Descripcion = descripcion;
        }
        
    }
}