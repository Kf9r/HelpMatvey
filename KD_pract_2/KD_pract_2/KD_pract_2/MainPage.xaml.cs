using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KD_pract_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия кнопки
        private void GreetButton_Clicked(object sender, EventArgs e)
        {
            // Обращаемся к элементам по именам (x:Name), заданным в XAML
            greetingLabel.Text = $"Привет, {nameEntry.Text}!";
        }

    }
}
