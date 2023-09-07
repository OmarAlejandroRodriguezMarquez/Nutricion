using Nutricion.Models;

namespace Nutricion.Pages;

public partial class DatosPage : ContentPage
{
	public DatosPage(string nombre)
	{
		InitializeComponent();
		Obtener();
		lblNombre.Text = nombre;
	}

    private async void btnIMC_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new IMCPage());
    }

	private void Obtener()
	{
		List<IMC> registros = App.IMCrepository.ObtenerRegistros();
		lstRegistros.ItemsSource = registros;
		DisplayAlert("Consulta",App.IMCrepository.StatusMessage,"Ok");
	}
}