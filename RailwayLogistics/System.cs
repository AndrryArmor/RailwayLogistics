using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class System : ISystem
    {
        private string _adminPassword = "admin";

        private List<Delivery> _deliveries;
        private List<Station> _stations;
        private List<Client> _clients;

        public System()
        {
            _deliveries = new List<Delivery>();
            _stations = new List<Station>
            {
                new Station("Київ",
                    new List<Wagon>
                    {
                        new Wagon(34, 80, 120),
                        new Wagon(28, 60, 76),
                        new Wagon(44, 70, 150)
                    },
                    new List<Locomotive>
                    {
                        new Locomotive(45, 240)
                    }),
                new Station("Вінниця",
                    new List<Wagon>
                    {
                        new Wagon(34, 80, 120),
                        new Wagon(28, 60, 76),
                        new Wagon(44, 70, 150)
                    },
                    new List<Locomotive>
                    {
                        new Locomotive(40, 200)
                    }),
                new Station("Харків",
                    new List<Wagon>
                    {
                        new Wagon(34, 80, 120),
                        new Wagon(28, 60, 76),
                        new Wagon(44, 70, 150)
                    },
                    new List<Locomotive>
                    {
                        new Locomotive(37, 190)
                    })
            };
            _clients = new List<Client>();
        }

        public System(IEnumerable<Delivery> deliveries) : this()
        {
            _deliveries.AddRange(deliveries);
        }

        public ReadOnlyCollection<Client> Clients => _clients.AsReadOnly();
        public ReadOnlyCollection<Station> Stations => _stations.AsReadOnly();
        public ReadOnlyCollection<Delivery> Deliveries => _deliveries.AsReadOnly();

        public void AuthoriseNewClient(Client client, string password)
        {
            if (client.IsAdministrator && password != _adminPassword)
                throw new RegistrationException();

            _clients.Add(client);
        }

        public IEnumerable<Delivery> GetDeliveries()
        {            
            return _deliveries;
        }

        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }

        public int CalculateRouteLength(Station departureStation, Station arrivalStation)
        {
            return 0;
        }

        public Train CreateTrain(Locomotive locomotive, IEnumerable<Wagon> wagons)
        {
            return new Train(locomotive, wagons);
        }

        public IEnumerable<Station> GetStations()
        {
            return Stations;
        }
    }
}
