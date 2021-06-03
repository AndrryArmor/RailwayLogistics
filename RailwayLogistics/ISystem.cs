using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public interface ISystem
    {
        void AuthoriseNewClient(Client client, string password = null);
        IEnumerable<Delivery> GetDeliveries();
        void AddDelivery(Delivery delivery);
        int CalculateRouteLength(Station departureStation, Station arrivalStation);
        Train CreateTrain(Locomotive locomotive, IEnumerable<Wagon> wagons);
        IEnumerable<Station> GetStations();
    }
}
