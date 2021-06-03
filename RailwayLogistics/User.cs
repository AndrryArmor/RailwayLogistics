using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class User : Client
    {
        public User(string name, ISystem system) : base(name, system)
        {
            Name = name;
            System = system;
        }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return System.GetDeliveries();
        }

        public void AddDelivery(string good, int weight, int volume, string departureStation, string arrivalStation)
        {
            Station _departureStation = System.GetStations().Where(station => station.Name == departureStation).First();
            Station _arrivalStation = System.GetStations().Where(station => station.Name == arrivalStation).First();
            Delivery delivery = new Delivery(good, weight, volume, _departureStation, _arrivalStation);
            delivery.RouteLength = System.CalculateRouteLength(_departureStation, _arrivalStation);
            delivery.CountPrice();
            System.AddDelivery(delivery);
        }
    }
}
