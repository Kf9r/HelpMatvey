using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DK_FlexLayout.Models;
using Xamarin.Forms;

namespace DK_FlexLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GalleryViewModel();
        }
    }

    public class GalleryViewModel : BindableObject
    {
        public List<ImageItem> Images { get; set; }
        public ICommand TapImageCommand { get; }

        public GalleryViewModel()
        {
            Images = new List<ImageItem>
            {
                new ImageItem { ImagePath = "Resources/Event_1.png", ImageName = "Изображение 1" },
                new ImageItem { ImagePath = "Resources/Event_2.png", ImageName = "Изображение 2" },
                new ImageItem { ImagePath = "Resources/Event_3.png", ImageName = "Изображение 3" },
                new ImageItem { ImagePath = "Resources/Event_4.png", ImageName = "Изображение 4" },
                new ImageItem { ImagePath = "Resources/Event_5.png", ImageName = "Изображение 5" },
                new ImageItem { ImagePath = "Resources/a.jpg", ImageName = "Aaa" }
            };

            TapImageCommand = new Command<string>(OnImageTapped);
        }

        private void OnImageTapped(string imageName)
        {
            Application.Current.MainPage.DisplayAlert("Галерея",
                $"Вы выбрали: {imageName}", "OK");
        }
    }

}
