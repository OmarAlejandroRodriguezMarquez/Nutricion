using Microsoft.AppCenter.Crashes;
using Nutricion.Models;

namespace Nutricion.Pages;

public partial class IMCPage : ContentPage
{
	public IMCPage()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Crashes.GenerateTestCrash();
        }
        catch (Exception exception)
        {
            Crashes.TrackError(exception);
        }
        if (txtPeso.Text == null || txtAltura.Text == null) 
        {
            DisplayAlert("Alerta", "Rellene los datos", "Ok");
        }
        else
        {
            float peso, altura, resultado;
            peso = float.Parse(txtPeso.Text);
            altura = float.Parse(txtAltura.Text);

            resultado = peso / (altura * altura);

            IMC imc = new IMC();
            imc.Peso = peso;
            imc.Altura = altura;
            imc.Resultado = resultado;

            App.IMCrepository.AgregarRegistro(imc);
            lblGuardar.Text = App.IMCrepository.StatusMessage;

            if (resultado < 18.5)
            {
                lblResultado.Text = "Bajo peso";
                lblResultado.TextColor = Colors.Orange;
                imgResultado.Source = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQlyf9Z3hKRCVC6eBhpqAyDIivx6of7p6eyRQ&usqp=CAU"));
            }
            else if (resultado >= 18.5 && resultado < 24.9)
            {
                lblResultado.Text = "Normal";
                lblResultado.TextColor = Colors.Green;
            }
            else if (resultado >= 25 && resultado < 29.9)
            {
                lblResultado.Text = "Sobrepeso";
                lblResultado.TextColor = Colors.OrangeRed;
            }
            else if (resultado >= 30)
            {
                lblResultado.Text = "Obesidad";
                lblResultado.TextColor = Colors.Red;
            }
            else
            {
                lblResultado.Text = "Fuera de rango";
                lblResultado.TextColor = Colors.Purple;
            }
        }	
    }
}