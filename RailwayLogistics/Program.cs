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
            Administrator admin;

            do
            {
                Console.WriteLine("Введіть пароль адміністратора: ");
                string adminPassword = Console.ReadLine();
                try
                {
                    admin = new Administrator("Admin", adminPassword, system);
                    break;
                }
                catch (RegistrationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }while (true) ;

            var user = new User("Oleksii", system);

            user.AddDelivery("Пшениця", 150, 180, "Київ", "Вінниця");
            try
            {
                user.AddDelivery("Вугілля", 450,-200, "Вінниця", "Житомир");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }            

            try
            {
                var delivery = system.GetDeliveries().ToArray()[1];
            }
            catch (Exception ex) when (ex.Message.Contains("array"))
            {
                Console.WriteLine(ex.Message);
            }          

            Console.ReadKey();
        }
    }
}
