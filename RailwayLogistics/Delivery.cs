using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Delivery
    {
        public StatusType Status { get; set; }
        public string Good { get; }
        public int Weight { get; }
        public int Volume { get; }
        public int Price { get; }
        public Station DepartureStation { get; }
        public Station ArrivalStation { get; }
        public int RouteLength { get; }

        public void ChangeStatus(StatusType newStatus)
        {

        }

        public void AddTrain(Train train)
        {

        }

        private int CountPrice()
        {
            return 0;
        }
    }
}
