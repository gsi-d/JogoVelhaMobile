using JogoDaVelhaXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoDaVelhaXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaRelatorio : ContentPage
    {
        public TelaRelatorio()
        {
            InitializeComponent();
            BindingContext = new TelaRelatorioViewModel();
        }

        protected override async void  OnAppearing()
        {
            var vm = (TelaRelatorioViewModel)BindingContext;
            vm.AtualizarPartidas.Execute(null);
        }
    }
}