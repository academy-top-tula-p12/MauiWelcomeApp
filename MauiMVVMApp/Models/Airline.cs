using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVMApp.Models
{
    public class Airline
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? City { get; set; }
        public int? PlainsCount { get; set; }
    }
}
