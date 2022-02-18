using JogoDaVelhaXamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoVelhaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicial : ContentPage
    {
        public string MododeJogo;
        public MainPage mainPage = new MainPage();
        public IAMainPage IAmainPage = new IAMainPage();
        public TelaInicial()
        {
            InitializeComponent();

        }

        private void ButtonMultiplayer(object sender, EventArgs e)
        {
            MododeJogo = "Multiplayer";
            App.Current.MainPage = mainPage;
        }

        private void ButtonIA(object sender, EventArgs e)
        {
            MododeJogo = "IA";
            App.Current.MainPage = IAmainPage;
        }
    }
}