using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public CategoriaProducto Categoria { get; set; }
        public bool EstadoAgotado { get; set; }
        public string Foto { get; set; }
    }

    public class CategoriaProducto
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
    }
}
