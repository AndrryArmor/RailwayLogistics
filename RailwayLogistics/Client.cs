using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Client
    {
        public IEnumerable<Delivery> GetDeliveries()
        {
            return new List<Delivery>();
        }

        public void AddDelivery(string good, int weight, int volume, string departureStation, string arrivalStation)
        {

        }
    }
}
