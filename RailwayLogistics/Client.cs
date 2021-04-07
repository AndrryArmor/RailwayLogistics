using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Client
    {
        private string name;

        public Client()
        {
            Console.WriteLine("Створено об'єкт класу Client");
        }

        public Client(string name, System system) : this()
        {
            Name = name;
            System = system;
        }

        public Client(Client other) : this(other.Name, other.System)
        {
        }

        public string Name
        {
            get
            {
                Console.WriteLine("З властивості Name класу Client було зчитано значення {0}", name);
                return name;
            }

            set
            {
                name = value;
                Console.WriteLine("Властивості Name класу Client присвоєно значення {0}", name);
            }
        }
        public System System { get; set; }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return new List<Delivery>();
        }

        public void AddDelivery(string good, int weight, int volume, string departureStation, string arrivalStation)
        {
            Station _departureStation = System.Stations.Where(station => station.Name == departureStation).First();
            Station _arrivalStation = System.Stations.Where(station => station.Name == arrivalStation).First();
            Delivery delivery = new Delivery(good, weight, volume, _departureStation, _arrivalStation);
            delivery.RouteLength = System.CalculateRouteLength(_departureStation, _arrivalStation);
            delivery.CountPrice();
            System.AddDelivery(delivery);
        }
    }
}
