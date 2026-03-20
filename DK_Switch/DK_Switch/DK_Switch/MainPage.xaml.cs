using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DK_Switch
{
    public partial class MainPage : ContentPage
    {
        private Switch notificationSwitch;
        private Switch themeSwitch;

        public MainPage()
        {
            InitializeComponent();

            var tableView = new TableView
            {
                Intent = TableIntent.Settings
            };

            var tableRoot = new TableRoot();
            var tableSection = new TableSection("Настройки");

            var notificationCell = new ViewCell();
            var notificationLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(15, 10)
            };

            var notificationLabel = new Label
            {
                Text = "Уведомления",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            notificationSwitch = new Switch
            {
                HorizontalOptions = LayoutOptions.End
            };

            notificationSwitch.Toggled += OnSwitchToggled;

            notificationLayout.Children.Add(notificationLabel);
            notificationLayout.Children.Add(notificationSwitch);
            notificationCell.View = notificationLayout;

            var themeCell = new ViewCell();
            var themeLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(15, 10)
            };

            var themeLabel = new Label
            {
                Text = "Тёмная тема",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            themeSwitch = new Switch
            {
                HorizontalOptions = LayoutOptions.End
            };

            themeSwitch.Toggled += OnSwitchToggled;

            themeLayout.Children.Add(themeLabel);
            themeLayout.Children.Add(themeSwitch);
            themeCell.View = themeLayout;

            tableSection.Add(notificationCell);
            tableSection.Add(themeCell);

            tableRoot.Add(tableSection);

            tableView.Root = tableRoot;

            Content = tableView;
        }

        private async void OnSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (sender == notificationSwitch)
            {
                bool isOn = e.Value;
                string status = isOn ? "включены" : "выключены";

                await DisplayAlert("Уведомления",
                    $"Уведомления {status}", "ОК");
            }
            else if (sender == themeSwitch)
            {
                bool isOn = e.Value;
                string status = isOn ? "включена" : "выключена";

                await DisplayAlert("Тёмная тема",
                    $"Тёмная тема {status}", "ОК");
            }
        }
    }
}
