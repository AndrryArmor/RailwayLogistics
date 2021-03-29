using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Locomotive
    {
        public Locomotive()
        {
            Console.WriteLine("Створено об'єкт класу Locomotive");
        }

        public Locomotive(int weight, int maximumWeight) : this()
        {
            Weight = weight;
            MaximumWeight = maximumWeight;
        }

        public Locomotive(Locomotive other) : this(other.Weight, other.MaximumWeight)
        {
        }

        public int Weight { get; set; }
        public int MaximumWeight { get; set; }
    }
}
