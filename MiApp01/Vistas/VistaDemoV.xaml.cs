using MiApp01.VistasModelos;

namespace MiApp01.Vistas;

public partial class VistaDemoV : ContentPage
{
	public VistaDemoV()
	{
		InitializeComponent();
		BindingContext = new DemoMesasVM();
	}
}