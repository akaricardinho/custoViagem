using custoViagem.Models;

namespace custoViagem.Views;

public partial class CriarPedagio : ContentPage
{
	public CriarPedagio()
	{
		InitializeComponent();
	}

    private async void btnAdicionar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Pedagio p = new Pedagio
            {
                Local = txtLocal.Text,
                Valor = Convert.ToDouble(txtValor.Text),
            };

            await App.Db.Insert(p);
            await DisplayAlert("Sucesso!", "Pedágio inserido", "OK");
            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}