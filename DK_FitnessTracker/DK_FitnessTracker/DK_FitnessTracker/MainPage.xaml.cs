using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DK_FitnessTracker
{
    public partial class MainPage : ContentPage
    {
        private Label titleLabel;
        private Label instructionLabel;
        private Stepper stepper;
        private Label stepperValueLabel;
        private Label currentLabel;
        private Button saveButton;
        private Label savedLabel;

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

            titleLabel = new Label
            {
                Text = "Трекер упражнений",
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            instructionLabel = new Label
            {
                Text = "Выберите количество повторений:",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center
            };

            var stepperLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 10
            };

            stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 100,
                Increment = 1,
                Value = 10
            };

            stepper.ValueChanged += OnStepperValueChanged;

            stepperValueLabel = new Label
            {
                Text = "10",
                FontSize = 18,
                VerticalOptions = LayoutOptions.Center
            };

            stepperLayout.Children.Add(stepper);
            stepperLayout.Children.Add(stepperValueLabel);

            currentLabel = new Label
            {
                Text = "Текущее значение: 10",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center
            };

            saveButton = new Button
            {
                Text = "Сохранить",
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200
            };

            saveButton.Clicked += OnSaveButtonClicked;

            savedLabel = new Label
            {
                Text = "Сохранено: -",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Center
            };

            stackLayout.Children.Add(titleLabel);
            stackLayout.Children.Add(instructionLabel);
            stackLayout.Children.Add(stepperLayout);
            stackLayout.Children.Add(currentLabel);
            stackLayout.Children.Add(saveButton);
            stackLayout.Children.Add(savedLabel);

            Content = stackLayout;
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            stepperValueLabel.Text = value.ToString();
            currentLabel.Text = $"Текущее значение: {value}";
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            int repetitions = (int)stepper.Value;

            DisplayAlert("Сохранено", $"Вы сохранили {repetitions} повторений", "ОК");

            savedLabel.Text = $"Сохранено: {repetitions} повторений";
        }
    }
}
