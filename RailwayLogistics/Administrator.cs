using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class Administrator : Client
    {
        public Administrator(string name, ISystem system) : base(name, system, true)
        {
            Name = name;
            System = system;
        }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return System.GetDeliveries();
        }

        public IEnumerable<Station> GetStations()
        {
            return new List<Station>();
        }

        public void AddTrainToDelivery(Delivery delivery, Train train)
        {
            delivery.AddTrain(train);
        }

        public void MarkAsInProgress(Delivery delivery)
        {
            delivery.ChangeStatus(StatusType.InProgress);
        }
    }
}
