using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    class Program
    {
        static void Main(string[] args)
        {
            System system = new System();
            system.Start();
            Administrator administrator = system.Administrator;
            Client client = system.AuthoriseNewClient("Oleksii");
            client.AddDelivery("Пшениця", 150, 180, "Київ", "Вінниця");
            
            var deliveries = new List<Delivery>(administrator.GetDeliveries());
            var delivery = deliveries[0];
            var locomotive = delivery.DepartureStation.Locomotives[0];
            var wagons = delivery.DepartureStation.Wagons;
            administrator.AddTrainToDelivery(delivery, new Train(locomotive, wagons));
            administrator.MarkAsInProgress(delivery);
            Console.ReadKey();
        }
    }
}
