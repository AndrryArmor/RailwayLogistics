using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Wagon
    {
        public Wagon()
        {
            Console.WriteLine("Створено об'єкт класу Wagon");
        }

        public Wagon(int weight, int maximumWeight, int volume) : this()
        {
            Weight = weight;
            MaximumWeight = maximumWeight;
            Volume = volume;
        }

        public Wagon(Wagon other) : this(other.Weight, other.MaximumWeight, other.Volume)
        {
        }

        public int Weight { get; set; }
        public int MaximumWeight { get; set; }
        public int Volume { get; set; }
    }
}
