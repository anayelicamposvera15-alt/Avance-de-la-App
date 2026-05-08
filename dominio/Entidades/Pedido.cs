using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class Pedido
    {
        // Propiedades
        public int IdPedido { get; set; }
        public DateTime FechaHora { get; set; }
        public Usuario Mesero { get; set; }
        public Mesa Mesa { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }

        // Constructor
        public Pedido(int idPedido, Usuario mesero, Mesa mesa, EstadoPedido estadoPedido)
        {
            IdPedido = idPedido;
            FechaHora = DateTime.Now;
            Mesero = mesero;
            Mesa = mesa;
            EstadoPedido = estadoPedido;
            ItemPedido = new List<ItemPedido>();
        }
    }
}
