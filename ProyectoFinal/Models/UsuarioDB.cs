using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace ProyectoFinal.Models
{
    [Table("Usuarios")]
    public class UsuarioDB
    {
        [PrimaryKey, AutoIncrement]
        public int UsuarioId { get; set; }
        public string Correo { get; set; }
        public string Username { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Membresia { get; set; }
        public string claveAdministrador { get; set; }
    }
}