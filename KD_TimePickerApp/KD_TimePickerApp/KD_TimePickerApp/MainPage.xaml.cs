using System;
using System.Threading;
using Xamarin.Forms;

namespace KD_TimePickerApp
{
    public partial class MainPage : ContentPage
    {
        private Timer _timer;
        private bool _isTimerRunning = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            if (!_isTimerRunning)
            {
                TimeSpan selectedTime = timePicker.Time;

                _timer = new Timer(TimerElapsed, null, 0, 1000);

                _isTimerRunning = true;
                startButton.Text = "Остановить таймер";
                resultLabel.Text = $"Таймер запущен в {selectedTime:hh\\:mm}";
            }
            else
            {
                _timer?.Dispose();
                _timer = null;

                _isTimerRunning = false;
                startButton.Text = "Запустить таймер";
                resultLabel.Text = "Таймер остановлен";
            }
        }

        private void TimerElapsed(object state)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                DateTime currentTime = DateTime.Now;

                resultLabel.Text = $"Текущее время: {currentTime:HH:mm:ss}";
            });
        }
    }
}
