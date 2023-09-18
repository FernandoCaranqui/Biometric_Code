using System;

namespace Biometrico.Models.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string Identificacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string access_token { get; set; }
        public string ip { get; set; }
        public string correo { get; set; }
        public bool aceptaTerminos { get; set; }
    }
}