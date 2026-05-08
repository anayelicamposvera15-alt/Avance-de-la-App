using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entidades
{
    public class Mesa
    {
        public int IdMesa {  get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidad { get; set; }
        public EstadoMesa EstadoMesa { get; set; }
        public Ambiente Ambiente { get; set; }
        // Constructor de la clase Mesa
        public Mesa(int id, int numero, int capacidad, EstadoMesa estadoMesa, Ambiente ambiente)
        {
            // Validacion de valores a asignar
            if (id <= 0)
                throw new ArgumentException("El Id debe ser > 0");
            if (numero <= 0)
                throw new ArgumentException("El número de mesa debe ser > 0");
            if (capacidad <= 0)
                throw new ArgumentException("La capacidad debe ser > 0");
            if (estadoMesa == null)
                throw new ArgumentNullException("El estado de la mesa no puede ser nulo");
            if (ambiente == null)
                throw new ArgumentNullException("El ambiente no puede ser nulo");

            // Asignacion de valores a los atributos de la clase
            IdMesa = id;
            NumeroMesa = numero;
            Capacidad = capacidad;
            EstadoMesa = estadoMesa;
            Ambiente = ambiente;
        }
    }
}

