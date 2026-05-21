using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Estéticamente Raro só Existem 3 no Mundo",
                ValorDiariaAdulto = 650.0,
                ValorDiariaCrianca = 300.0
            },

            new Quarto()
            {
                Descricao = "Suíte E o Caba Vai Endoidar é?",
                ValorDiariaAdulto = 450.0,
                ValorDiariaCrianca = 235.0
            },

            new Quarto()
            {
                Descricao = "Suíte Somente Eu",
                ValorDiariaAdulto = 350.0,
                ValorDiariaCrianca = 180.0
            },

            new Quarto()
            {
                Descricao = "Suíte Coitadinho da Silva",
                ValorDiariaAdulto = 199.99,
                ValorDiariaCrianca = 99.99
            },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500;
            window.Height = 700;

            return window;
        }
    }
}