using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMVVMApp.Models
{
    public class AirlinesViewModel : INotifyPropertyChanged
    {
        AirlineViewModel airline = new();

        string buttonAddText;
        public string ButtonAddText
        {
            get => buttonAddText;
            set
            {
                buttonAddText = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<AirlineViewModel> Airlines { get; set; } 
            = new ObservableCollection<AirlineViewModel>();

        string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        string city;
        public string? City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        int? plainsCount;
        public int? PlainsCount
        {
            get => plainsCount;
            set
            {
                plainsCount = value;
                OnPropertyChanged();
            }
        }

        bool editMode = false;
        
        public ICommand AddAirlineCommand { get; set; }
        public ICommand RemoveAirlineCommand { get; set; }
        public ICommand EditAirlineCommand { get; set; }

        public AirlinesViewModel()
        {
            AddAirlineCommand = new Command(() =>
            {
                if(editMode)
                {
                    airline.Title = Title;
                    airline.City = City;
                    airline.PlainsCount = PlainsCount;

                    editMode = false;
                    ButtonAddText = "Add Airline";
                }
                else
                {
                    Airlines.Add(new()
                    {
                        Title = Title,
                        City = City,
                        PlainsCount = PlainsCount,
                    });
                }
                    
                Title = "";
                City = "";
                PlainsCount = 0;
            },
            () =>
            {
                if (airline.Title is null || airline.Title.Trim().Length == 0)
                    return false;
                
                if(airline.PlainsCount is not null)
                {
                    if(!Int32.TryParse(airline.PlainsCount.Value.ToString(), out int value))
                        return false;
                    if(value < 0)
                        return false;
                }    

                return true;
                
            });

            RemoveAirlineCommand = new Command((object? args) =>
            {
                if(args is AirlineViewModel airline)
                {
                    Airlines.Remove(airline);
                }
            });

            EditAirlineCommand = new Command((object? args) =>
            {
                editMode = true;
                ButtonAddText = "Save Airline";
                airline = Airlines.FirstOrDefault(a => a == args)!;
                if(airline is not null)
                {
                    Title = airline.Title;
                    City = airline?.City;
                    PlainsCount = airline?.PlainsCount;
                }
            });

            ButtonAddText = "Add Airline";
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            ((Command)AddAirlineCommand).ChangeCanExecute();
        }
    }
}
