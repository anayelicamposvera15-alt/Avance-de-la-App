using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class EstadoMesa
    {
        public int IdEstadoMesa { get; set; }
        public string NombreEstado { get; set; }
        public string ColorVisual { get; set; }
        // Contructor de la clase EstadoMesa 

        public EstadoMesa(int id, string nombre , string colorVisual  )
        {
            //Validacion de valores a asignar 
            if (id <= 0)
                throw new ArgumentException("El Id debe ser >0");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser vacío");
            if (string.IsNullOrWhiteSpace(colorVisual))
                throw new ArgumentException("el color no puede estar vacio");

            // Asignacion de valores a los atributos de la clase 
            IdEstadoMesa = id;
            NombreEstado = nombre;
            ColorVisual = colorVisual;



        }
    }
}
