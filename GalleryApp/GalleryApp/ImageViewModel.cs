using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace GalleryApp
{
    public class ImageViewModel : BindableObject
    {
        private List<string> images = new List<string>
        {
            "image1", // Указываем только имя без расширения
            "image2",
            "image3",
            "image4",
            "image5",
            "image6"
        };

        public List<string> Images => images;

        public ICommand TapImageCommand { get; }

        public ImageViewModel()
        {
            TapImageCommand = new Command<string>(OnImageTapped);
        }

        private async void OnImageTapped(string imageName)
        {
            await Application.Current.MainPage.DisplayAlert("Image Tapped", $"You tapped on {imageName}", "OK");
        }
    }
}