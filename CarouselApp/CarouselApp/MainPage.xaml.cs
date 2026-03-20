using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var carouselView = new CarouselView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var carouselData = new List<string>
            {
                "Программирование",
                "Дизайн",
                "Продажи"
            };

            carouselView.ItemTemplate = new DataTemplate(() =>
            {
                var frame = new Frame
                {
                    Padding = 10,
                    Margin = 5,
                    BorderColor = Color.Gray,
                    CornerRadius = 10
                };

                var label = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 24
                };

                label.SetBinding(Label.TextProperty, ".");

                frame.Content = label;

                return frame;
            });

            carouselView.ItemsSource = carouselData;

            Content = new StackLayout
            {
                Children = { carouselView }
            };
        }
    }
}
