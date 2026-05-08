using System;
using System.Collections.ObjectModel;
using System.Text;
using aplicacion.DTOs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MiApp01.VistasModelos
{
    public partial class DemoMesasVM : ObservableObject
    {
        [ObservableProperty]
        public partial ObservableCollection<String> ListaMesas { get; set; }

        [RelayCommand]
        private void CargarMesas()
            {
            ListaMesas = new ObservableCollection<string>
            {
                "Mesa 1 = Libre ",
                "Mesa 2 = Ocupada ",
                "Mesa 3 = Resevada ",
                "Mesa 4 = Libre ",
                "Mesa 5 = Ocupada "
            };
            }
        [ObservableProperty]
        private ObservableCollection<MesaDto> listaMesasDTO;
        [RelayCommand]
        private void CargarMesaDTO()

        {
            ListaMesasDTO = new ObservableCollection<MesaDto>
            {
                new MesaDto { IdMesa = 1 ,NumeroMesa = 1 ,Capacidad = 4, EstadoId = 1, EstadoMesa = "Libre", NombreColor = "DarkGreen" },
                new MesaDto { IdMesa = 2 ,NumeroMesa = 2 ,Capacidad = 6, EstadoId = 2, EstadoMesa = "Ocupada", NombreColor = "DarkRed" },
                new MesaDto { IdMesa = 3 ,NumeroMesa = 3 ,Capacidad = 2, EstadoId = 3, EstadoMesa = "Reservada", NombreColor = "DarkOrange" }
            };

        }

        public DemoMesasVM()
        {
            ListaMesas = new ObservableCollection<string> { };
        }
    }
}
