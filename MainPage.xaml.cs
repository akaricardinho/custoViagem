using custoViagem.Models;

namespace custoViagem
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public static Viagem via = new Viagem();

        private void btnCreatePedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.CriarPedagio());
        }

        private void btnListaPedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.ListaPedagio());
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            via.Origem = txtOrigem.Text;
            via.Destino = txtDestino.Text;
            via.Distancia = Convert.ToDouble(txtDistancia.Text);
            via.Rendimento = Convert.ToDouble(txtRendimento.Text);
            via.Preco = Convert.ToDouble(txtCombustivel.Text);

            await Navigation.PushAsync(new Views.CalcularPedagio());
        }
    }

}
