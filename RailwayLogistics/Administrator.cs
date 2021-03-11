using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Administrator
    {
        public IEnumerable<Delivery> GetDeliveries()
        {
            return new List<Delivery>();
        }

        public IEnumerable<Station> GetStations()
        {
            return new List<Station>();
        }

        public void CreateTrain(Locomotive locomotive, IEnumerable<Wagon> wagons)
        {
               
        }

        public void ChangeDeliveryStatus(Delivery delivery)
        {

        }
    }
}
