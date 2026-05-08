using aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using dominio.Entidades;

namespace aplicacion.Mappings
{
    public static class MappingExtensions
    {

        public static MesaDto ToDto(this Mesa mesa)
        {
            return new MesaDto
            {
                IdMesa = mesa.IdMesa,
                NumeroMesa = mesa.NumeroMesa,
                Capacidad = mesa.Capacidad

            };
        }

        //Convertir la lista de Entidades Mesa a la Lista de Mesa Dto 
        public static List<MesaDto> ToDtoList(this IEnumerable<Mesa> mesas)
        {
            //Select es un metodo de LINQ que permite proyecta cada elemento 
            return mesas.Select(mesa => mesa.ToDto()).ToList();
        }
    }
}