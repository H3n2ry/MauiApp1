using System.Collections;


using MauiApp1.models;

namespace MauiApp1
{
    public partial class App : Application
    {
        public List<lugares> Lista_lugares = new List<lugares>
        {
           new lugares()
            {
                Descricao = "Carrão" ,
                Valorporpessoa = 120.0,

            },
           new lugares()
           {
               Descricao = "Tatuapé",
               Valorporpessoa = 120.0
           }
        };


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new pastaApEv.projeto());
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