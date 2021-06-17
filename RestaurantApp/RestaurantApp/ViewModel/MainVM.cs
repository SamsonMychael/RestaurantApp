using RestaurantApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
   public class MainVM : INotifyPropertyChanged
    {
        public MainVM()
        {
            Picks = GetPicks();
        }
        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        public event PropertyChangedEventHandler PropertyChanged;

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Breakfast", Image = "IMG01.png",
                    Description = "Order our healthy and warm breakfast menu for a great morning" },
                new Pick { Title = "Lunch", Image = "IMG03.png",
                    Description = "Delicious lunch to keep your day sweet and smooth" }
            };
        }
        private void OnpropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
   
}

