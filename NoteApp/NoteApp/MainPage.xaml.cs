using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
namespace NoteApp
{

    public partial class MainPage : ContentPage
    {
        string filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "note.txt");

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NoteEditor.Text))
            {
                await DisplayAlert("Ошибка", "Нельзя сохранить пустую заметку!", "ОК");
                return;
            }

            File.WriteAllText(filePath, NoteEditor.Text);
            await DisplayAlert("Успех", "Заметка сохранена!", "ОК");
        }

        private async void OnLoadButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                NoteEditor.Text = File.ReadAllText(filePath);
                await DisplayAlert("Успех", "Заметка загружена!", "ОК");
            }
            else
            {
                await DisplayAlert("Ошибка", "Файл заметки не найден!", "ОК");
            }
        }
    }
}
