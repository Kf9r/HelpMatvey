using System;
using Xamarin.Forms;

namespace DK_PickerApp
{
    public partial class MainPage : ContentPage
    {
        private Label labelPrompt;
        private Picker optionPicker;  
        private Label resultLabel;

        public MainPage()
        {
            InitializeComponent();

            var stackLayout = new StackLayout
            {
                Padding = 20,
                Spacing = 15,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            labelPrompt = new Label
            {
                Text = "Выберите опцию:",
                FontSize = 18,
                HorizontalOptions = LayoutOptions.Center
            };

            optionPicker = new Picker  
            {
                Title = "Выберите...",
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200
            };

            optionPicker.Items.Add("Вариант 1");
            optionPicker.Items.Add("Вариант 2");
            optionPicker.Items.Add("Вариант 3");
            optionPicker.Items.Add("Вариант 4");

            optionPicker.SelectedIndexChanged += OnOptionSelected;

            resultLabel = new Label
            {
                Text = "Опция не выбрана",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Default  
            };

            stackLayout.Children.Add(labelPrompt);
            stackLayout.Children.Add(optionPicker);
            stackLayout.Children.Add(resultLabel);

            Content = stackLayout;
        }

        private void OnOptionSelected(object sender, EventArgs e)
        {
            string selectedOption = optionPicker.SelectedItem?.ToString();

            if (selectedOption != null)
            {
                switch (selectedOption)
                {
                    case "Вариант 1":
                        resultLabel.Text = "Вы выбрали: Бибу";
                        break;
                    case "Вариант 2":
                        resultLabel.Text = "Вы выбрали: Бобу";
                        break;
                    case "Вариант 3":
                        resultLabel.Text = "Вы выбрали: Антона";
                        break;
                    case "Вариант 4":
                        resultLabel.Text = "Вы выбрали: Мактрахер";
                        break;
                    default:
                        resultLabel.Text = "Неизвестная опция";
                        break;
                }
            }
        }
    }
}