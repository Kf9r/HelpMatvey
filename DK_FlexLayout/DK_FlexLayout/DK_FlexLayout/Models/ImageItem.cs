using System.Windows.Input;
using Xamarin.Forms;

namespace DK_FlexLayout.Models
{
    public class ImageItem
    {
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public ICommand TapCommand { get; set; }
    }
}
