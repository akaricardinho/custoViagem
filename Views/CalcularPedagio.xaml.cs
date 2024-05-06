using custoViagem.Models;

namespace custoViagem.Views;

public partial class CalcularPedagio : ContentPage
{
	public CalcularPedagio()
	{
		InitializeComponent();
	}

    private async void btnNovaViagem_Clicked(object sender, EventArgs e)
    {
        List<Pedagio> pedagios = await App.Db.GetAll();
        foreach (Pedagio p in pedagios)
        {
            await App.Db.Delete(p.Id);
        }

        MainPage.via.Distancia = -1;
        MainPage.via.Rendimento = -1;
        MainPage.via.Origem = " ";
        MainPage.via.Preco = -1;
        MainPage.via.Destino = " ";

        await Navigation.PushAsync(new MainPage());

    }

    private async void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double consumo_carro = ((MainPage.via.Distancia / MainPage.via.Rendimento) * MainPage.via.Preco);
        double valor_pedagio = 0;
        double total = 0;

        List<Pedagio> pedagios = await App.Db.GetAll();
        foreach (Pedagio p in pedagios)
        {
            valor_pedagio += p.Valor;
        }

        total = consumo_carro + valor_pedagio;
        await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\n" +
            $"Consumo: {consumo_carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "Ok");
        lblValor.Text = "Valor: " + total.ToString("C");
        lblValor.IsVisible = true;
        lblOrigem.Text = MainPage.via.Origem;
        lblDestino.Text = MainPage.via.Destino;
        lblValor.Text = total.ToString("C");
    }
}