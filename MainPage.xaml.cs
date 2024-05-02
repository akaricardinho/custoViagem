namespace custoViagem
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCreatePedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.CriarPedagio());
        }

        private void btnListaPedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.ListaPedagio());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.CalcularPedagio());
        }
    }

}
