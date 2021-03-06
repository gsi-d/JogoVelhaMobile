using JogoDaVelhaXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JogoVelhaMobile.Helpers
{
    public class LabelCustom : Label
    {
        public bool PassouDeDez
        {
            get { return (bool)GetValue(PasssouDeDezProperty); }
            set { SetValue(PasssouDeDezProperty, value); }
        }

        public static readonly BindableProperty PasssouDeDezProperty = BindableProperty.Create(
           nameof(PassouDeDez),
           typeof(bool),
           typeof(LabelCustom),
           default(bool) 
       );


        public LabelCustom()
        {
            this.BindingContext = new TelaJogoViewModel();
        }
    }
}
