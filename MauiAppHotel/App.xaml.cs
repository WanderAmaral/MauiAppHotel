
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> list_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte super luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 50.5
            },
            new Quarto()
            {
                Descricao = "Suíte luxo",
                ValorDiariaAdulto = 100,
                ValorDiariaCrianca = 40.5
            },
            new Quarto()
            {
                Descricao = "Suíte single",
                ValorDiariaAdulto = 90,
                ValorDiariaCrianca = 30.5
            },
            new Quarto()
            {
                Descricao = "Suíte crise",
                ValorDiariaAdulto = 80,
                ValorDiariaCrianca = 20.5
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
