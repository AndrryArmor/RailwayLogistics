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
            new Administrator("Admin", system);
            new User("Oleksii", system);

            var user = (User)system.Clients.Where(client => !client.IsAdministrator).FirstOrDefault();
            user.AddDelivery("Пшениця", 150, 180, "Київ", "Вінниця");
            Console.WriteLine("Відбувся DownCast класу Client до класу User");

            var admin = (Administrator)system.Clients.Where(client => client.IsAdministrator).FirstOrDefault();
            var deliveries = new List<Delivery>(admin.GetDeliveries());
            admin.MarkAsInProgress(deliveries[0]);
            Console.WriteLine("Відбувся DownCast класу Client до класу Administrator");

            Console.ReadKey();
        }
    }
}
