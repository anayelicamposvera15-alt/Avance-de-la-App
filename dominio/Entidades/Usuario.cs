using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public Rol Rol { get; set; }
        public bool Activo { get; set; }
    }
    public enum Rol
    {
        Mesero,
        Cajero,
        Administrador
    }
}
