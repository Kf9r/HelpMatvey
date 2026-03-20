using System.Collections.Generic;
using Xamarin.Forms;

namespace FruitListApp
{
    public partial class MainPage : ContentPage
    {
        // Список фруктов
        private List<string> fruits;

        public MainPage()
        {
            InitializeComponent();
            fruits = new List<string>();
            FruitListView.ItemsSource = fruits; // Привязка списка к ListView
        }
        // Метод для добавления фрукта
        private void OnAddFruitClicked(object sender, System.EventArgs e)
        {
            var fruitName = NewFruitEntry.Text;
            if (!string.IsNullOrEmpty(fruitName))
            {
                fruits.Add(fruitName); // Добавление нового фрукта в список
                NewFruitEntry.Text = string.Empty; // Очистка поля ввода
                FruitListView.ItemsSource = null; // Обновление списка
                FruitListView.ItemsSource = fruits; // Привязка обновленного списка
            }
        }
    }
}
