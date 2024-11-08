
using MauiAppHOTEL.Models;

namespace MauiAppHOTEL
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
            Descricao = "Suíte Super Luxo",
                ValordiariaAdulto = 110.0,
                Valordiariacrianca = 55.0,
            },


            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValordiariaAdulto = 80.0,
                Valordiariacrianca = 40.0,
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValordiariaAdulto = 50.0,
                Valordiariacrianca = 25.0,
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValordiariaAdulto = 25,
                Valordiariacrianca = 12.5,
            }

        };
    public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Contratacaodahospedagem());
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
