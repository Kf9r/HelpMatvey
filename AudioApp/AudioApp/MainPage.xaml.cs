using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AudioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPlayAudioClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudioService>().PlayAudio();
        }

        private void OnStopAudioClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudioService>().StopAudio();
        }
    }
}
