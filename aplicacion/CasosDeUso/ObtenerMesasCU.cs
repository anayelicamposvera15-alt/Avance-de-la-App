using aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using dominio.Entidades;
using aplicacion.Mappings;
using aplicacion.DTOs;

namespace aplicacion.CasosDeUso
{
    public class ObtenerMesasCU
    {
        private readonly IRepository<Mesa> _mesaRepository;

        public ObtenerMesasCU(IRepository<Mesa> mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }
        public async Task<List<MesaDto>> EjecutarAsync()
        {
            var mesas = await _mesaRepository.GetAllAsync();
             return mesas.ToDtoList();
        }
            


    }
}
