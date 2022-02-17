using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JogoDaVelhaXamarin.ViewModels;
using System.Windows.Input;
using JogoDaVelhaXamarin.Models;
using JogoVelhaMobile.Views;

namespace JogoDaVelhaXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaJogo : ContentPage
    {
        public TelaJogoViewModel jogoViewModel = new TelaJogoViewModel();
        public TelaInicial telaInicial = new TelaInicial();

        public TelaJogo()
        {
            InitializeComponent();
            BindingContext = jogoViewModel;
        }
        private async void button_Clicked(object sender, EventArgs e)
        {
                try
                {
                    Button botao = sender as Button;
                    botao.Text = jogoViewModel.validaCaractere(botao.ClassId);
                    bool resultado = await jogoViewModel.validaResultado(button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
                    if (resultado)
                    {
                        voltaBotoes();
                    }

                    else if (jogoViewModel.Vencedor != "")
                    {
                        button1.Clicked -= button_Clicked;
                        button2.Clicked -= button_Clicked;
                        button3.Clicked -= button_Clicked;
                        button4.Clicked -= button_Clicked;
                        button5.Clicked -= button_Clicked;
                        button6.Clicked -= button_Clicked;
                        button7.Clicked -= button_Clicked;
                        button8.Clicked -= button_Clicked;
                        button9.Clicked -= button_Clicked;
                    }
                    else
                    {
                        botao.Clicked -= button_Clicked;
                    }

                    if (jogoViewModel.ContadorX >= 10)
                        lblX.BackgroundColor = Color.Transparent;
                    if (jogoViewModel.ContadorO >= 10)
                        lblO.BackgroundColor = Color.Transparent;
                }

                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Ops", ex.Message, "OK");
                }

            
            
        }
            

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            button1.Clicked += button_Clicked;
            button2.Clicked += button_Clicked;
            button3.Clicked += button_Clicked;
            button4.Clicked += button_Clicked;
            button5.Clicked += button_Clicked;
            button6.Clicked += button_Clicked;
            button7.Clicked += button_Clicked;
            button8.Clicked += button_Clicked;
            button9.Clicked += button_Clicked;

            jogoViewModel.Vencedor = "";
        }

        public void voltaBotoes()
        {
            if (jogoViewModel.Vencedor != "")
            {
                button1.Clicked += button_Clicked;
                button2.Clicked += button_Clicked;
                button3.Clicked += button_Clicked;
                button4.Clicked += button_Clicked;
                button5.Clicked += button_Clicked;
                button6.Clicked += button_Clicked;
                button7.Clicked += button_Clicked;
                button8.Clicked += button_Clicked;
                button9.Clicked += button_Clicked;
                jogoViewModel.Vencedor = "";
            }
        }
    }
}