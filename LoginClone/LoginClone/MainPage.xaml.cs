using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginClone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(Object sender, EventArgs e)
        {
            PasswordFlex.TranslationX = Width;
            PasswordFlex.IsVisible = true;

            ImageFlex.TranslationY = 100;

            labelName.FadeTo(0, 250);
            await ImageFlex.TranslateTo(ImageFlex.TranslationX, 0, 250, easing: Easing.SinIn);

            await PasswordFlex.TranslateTo(0, PasswordFlex.TranslationY, 250, easing: Easing.SinIn);
        }
    }
}
