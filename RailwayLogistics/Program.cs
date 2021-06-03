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
            var admin = new Administrator("Admin", system);
            var user = new User("Oleksii", system);

            user.AddDelivery("Пшениця", 150, 180, "Київ", "Вінниця");
            Console.WriteLine("Замовлення додано");
            var delivery = system.GetDeliveries().ToList()[0];
            delivery.StatusChanged += status =>
            {
                Console.WriteLine($"Повторне повідомлення: статус змінено на {status}");
            };

            delivery.StatusChanged += delegate (StatusType status)
            {
                Console.WriteLine($"Втретє виводимо зміну статусу на {status}");
            };

            admin.MarkAsInProgress(delivery);          

            Console.ReadKey();
        }
    }
}
