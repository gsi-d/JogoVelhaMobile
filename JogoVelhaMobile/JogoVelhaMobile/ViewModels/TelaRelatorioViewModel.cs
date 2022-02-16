using JogoDaVelhaXamarin.Models;
using JogoVelhaMobile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JogoDaVelhaXamarin.ViewModels
{
    class TelaRelatorioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<Partida> listaPartidas = new ObservableCollection<Partida>();
        bool estaAtualizando = false;

        public ObservableCollection<Partida> ListaPartidas
        {
            get => listaPartidas;
            set => listaPartidas = value;
        }

        public bool EstaAtualizando
        {
            get => estaAtualizando;
            set
            {
                estaAtualizando = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EstaAtualizando"));
            }
        }

        public ICommand AtualizarPartidas
        {
            get => new Command(async () =>
            {
                try
                {
                    if (EstaAtualizando)
                        return;
                    EstaAtualizando = true;

                    List<Partida> tmp = await App.Database.Search();
                    ListaPartidas.Clear();
                    tmp.ForEach(i => ListaPartidas.Add(i));
                }
                catch(Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Ops", ex.Message, "OK");
                }
                finally
                {
                    EstaAtualizando = false;
                }
            });
        }

    }
}
