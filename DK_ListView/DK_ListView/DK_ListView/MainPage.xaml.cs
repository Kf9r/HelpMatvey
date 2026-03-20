using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DK_ListView.Models;

namespace DK_ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var books = new List<Book>
            {
                new Book { Title = "Война и мир", Author="Лев Толстой" , Year=1869 },
                new Book { Title = "Война и мир 2", Author="Лев Толстой" , Year=1879 },
                new Book { Title = "Война и мир 3", Author="Лев Толстой" , Year=1889 },
            };

            BooksListView.ItemsSource = books;
        }
    }
}
