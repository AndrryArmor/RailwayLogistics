using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

            Console.WriteLine("Ім'я адміністратора: {0}", administrator.Name);

            Console.WriteLine("Введіть ім'я клієнта: ");
            string adminName = Console.ReadLine();
            Client client = system.AuthoriseNewClient(adminName);
            Console.WriteLine("Ім'я клієнта: {0}", client.Name);

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
