using Xamarin.Forms;

namespace KD_pract_1
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label
            {
                Text = "Введите ваше имя",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center
            };

            Entry nameEntry = new Entry
            {
                Placeholder = "Введите ваше имя",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Button greetButton = new Button
            {
                Text = "Поздороваться",
                HorizontalOptions = LayoutOptions.Center
            };

            Label greetingLabel = new Label
            {
                // по аналогии
            };

             // Обработка нажатия кнопки
            greetButton.Clicked += (sender, e) =>
            {
                greetingLabel.Text = $"Привет, {nameEntry.Text}!";
            };
            // Создание вертикального стека для размещения элементов
            StackLayout stackLayout = new StackLayout
            {
                Children = { header, nameEntry, greetButton, greetingLabel },
                Padding = 20,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Установка содержимого страницы
            this.Content = stackLayout;
        }

    }
}