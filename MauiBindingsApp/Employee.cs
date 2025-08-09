using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingsApp
{
    public class Employee : INotifyPropertyChanged
    {
        string? name;
        int age;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
