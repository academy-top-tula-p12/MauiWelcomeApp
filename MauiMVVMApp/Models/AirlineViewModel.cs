using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVMApp.Models
{
    public class AirlineViewModel : INotifyPropertyChanged
    {
        Airline airline = new Airline();

        public string Title
        {
            get => airline.Title;
            set
            {
                airline.Title = value;
                OnPropertyChanged();
            }
        }

        public string? City
        {
            get => airline.City;
            set
            {
                airline.City = value;
                OnPropertyChanged();
            }
        }

        public int? PlainsCount
        {
            get => airline.PlainsCount;
            set
            {
                airline.PlainsCount = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
