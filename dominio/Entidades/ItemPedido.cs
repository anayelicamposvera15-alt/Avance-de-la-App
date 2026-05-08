using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class ItemPedido
    {
        public int IdItemPedido { get; set; }
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Nota { get; set; }
    }
}
