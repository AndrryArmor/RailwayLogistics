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
        }

        public Locomotive(int weight, int maximumWeight) : this()
        {
            Weight = weight;
            MaximumWeight = maximumWeight;
        }

        public int Weight { get; set; }
        public int MaximumWeight { get; set; }
    }
}
