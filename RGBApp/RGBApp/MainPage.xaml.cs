using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RGBApp
{
    public partial class MainPage : ContentPage
    {
        private Slider redSlider;
        private Slider greenSlider;
        private Slider blueSlider;
        private Label redLabel;
        private Label greenLabel;
        private Label blueLabel;
        private BoxView colorBox;
        private Button randomColorButton;

        public MainPage()
        {
            redSlider = CreateSlider();
            greenSlider = CreateSlider();
            blueSlider = CreateSlider();

            redLabel = CreateLabel("Red: 0");
            greenLabel = CreateLabel("Green: 0");
            blueLabel = CreateLabel("Blue: 0");

            colorBox = new BoxView
            {
                WidthRequest = 200,
                HeightRequest = 200,
                Color = Color.FromRgb(0, 0, 0) 
            };

            randomColorButton = new Button
            {
                Text = "Случайный цвет"
            };
            randomColorButton.Clicked += OnRandomColorButtonClicked;

            redSlider.ValueChanged += OnSliderValueChanged;
            greenSlider.ValueChanged += OnSliderValueChanged;
            blueSlider.ValueChanged += OnSliderValueChanged;

            var stackLayout = new StackLayout
            {
                Padding = 20,
                Children =
                {
                    redLabel,
                    redSlider,
                    greenLabel,
                    greenSlider,
                    blueLabel,
                    blueSlider,
                    colorBox,
                    randomColorButton
                }
            };

            Content = stackLayout;
        }

        private Slider CreateSlider()
        {
            return new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0
            };
        }

        private Label CreateLabel(string text)
        {
            return new Label
            {
                Text = text,
                FontSize = 20
            };
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            redLabel.Text = $"Red: {(int)redSlider.Value}";
            greenLabel.Text = $"Green: {(int)greenSlider.Value}";
            blueLabel.Text = $"Blue: {(int)blueSlider.Value}";

            colorBox.Color = Color.FromRgb((int)redSlider.Value, (int)greenSlider.Value, (int)blueSlider.Value);
        }

        private void OnRandomColorButtonClicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            redSlider.Value = red;
            greenSlider.Value = green;
            blueSlider.Value = blue;

            OnSliderValueChanged(null, null);
        }
    }
}
