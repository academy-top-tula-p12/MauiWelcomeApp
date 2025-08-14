using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionViewApp
{
    public class Airline
    {
        public string Title { get; set; } = null!;
        public string? City { get; set; }
        public string? Logo { get; set; }
        public int? Plains { get; set; }
    }
}
