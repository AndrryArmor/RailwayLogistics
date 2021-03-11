using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Train
    {
        public Locomotive Locomotive { get; }
        public List<Wagon> Wagons { get; }
    }
}
