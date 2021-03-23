using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class System
    {
        public List<Delivery> Deliveries;

        public void Start()
        {
            Console.WriteLine("Modeling started!");
            Console.ReadKey();
        }

        public bool Authorise(string login, string password)
        {
            return true;
        }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return new List<Delivery>();
        }

        public void AddDelivery(Delivery delivery)
        {

        }

        public int CalculateRouteLength(Station departureStation, Station arrivalStation)
        {
            return 0;
        }

        public Train CreateTrain(Locomotive locomotive, IEnumerable<Wagon> wagons)
        {
            return new Train();
        }

        public IEnumerable<Station> GetStations()
        {
            return new List<Station>();
        }
    }
}
