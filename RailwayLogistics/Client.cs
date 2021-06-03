using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public abstract class Client
    {

        protected Client(string name, string password, ISystem system, bool isAdministrator = false)
        {
            Name = name;
            System = system;
            IsAdministrator = isAdministrator;

            system.AuthoriseNewClient(this, password);
        }

        public string Name { get; set; }
        public ISystem System { get; set; }
        public bool IsAdministrator { get; set; }
    }
}
