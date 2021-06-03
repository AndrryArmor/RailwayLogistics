using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLogistics
{
    public class RegistrationException : Exception
    {
        private const string _defaultMessage = "Помилка реєстрації";
        public RegistrationException() : base(_defaultMessage)
        {
        }
    }
}
