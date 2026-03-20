using System;
using Xamarin.Forms;
using DK_CollectionView.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DK_CollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            BindingContext = new EventsViewModel();
        }
    }

    public class EventsViewModel : BindableObject
    {
        private string _title;
        private DateTime _date = DateTime.Now;
        private ObservableCollection<Event> _events;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Event> Events
        {
            get => _events;
            set
            {
                _events = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddEventCommand { get; }

        public EventsViewModel()
        {
            Events = new ObservableCollection<Event>
            {
                new Event { Title = "Встреча с командой", Date = DateTime.Now.AddHours(2) },
                new Event { Title = "Дедлайн проекта", Date = DateTime.Now.AddDays(1) },
                new Event { Title = "Конференция", Date = DateTime.Now.AddDays(3) }
            };

            AddEventCommand = new Command(AddEvent);
        }

        private void AddEvent()
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                Events.Add(new Event
                {
                    Title = Title,
                    Date = Date
                });

                Title = string.Empty;
                Date = DateTime.Now;
            }
        }
    }
}
