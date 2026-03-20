using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EventApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace EventApp
{
    public partial class MainPage : ContentPage
    {
        public EventsViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new EventsViewModel();
            BindingContext = ViewModel;
        }
    }

    public class EventsViewModel : BindableObject
    {
        private string title;
        private DateTime date;
        public ObservableCollection<Event> Events { get; set; }
        public ICommand AddEventCommand { get; }

        public EventsViewModel()
        {
            Events = new ObservableCollection<Event>();
            AddEventCommand = new Command(AddEvent);
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }

        private void AddEvent()
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                Events.Add(new Event { Title = Title, Date = Date });
                Title = string.Empty; // Очистка поля после добавления
            }
        }
    }
}
