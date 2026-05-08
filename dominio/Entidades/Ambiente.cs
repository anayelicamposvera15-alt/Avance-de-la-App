using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class Ambiente
    {
        public int IdAmbiente { get; set; }
        public string NombreAmbiente { get; set; }
        public int CapacidadTotal { get; set; }

        //Contructor de la clase Ambiente 
        public Ambiente(int id, String nombre, int capacidad)
        {
            //Validar valores 
            if (id <= 0)
                throw new ArgumentException("El id debe ser mayor >0");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del Ambiente no puede estar vacia");
            if (capacidad <= 0)
                throw new ArgumentException("La capacidad debe ser >0");

            //Asignar los valores 
            IdAmbiente = id;
            NombreAmbiente = nombre;
            CapacidadTotal = CapacidadTotal;
        }
    }
}
