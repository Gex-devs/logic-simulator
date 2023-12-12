using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.CustomException
{
    public class ConnectionAlreadyCreated : LogicGatesException
    {
        private const string defaultMessage = "Connection already made";
        public ConnectionAlreadyCreated() : base(defaultMessage)
        {


        }

        public ConnectionAlreadyCreated(string message) : base(message)
        {

        }

        public ConnectionAlreadyCreated(string message, Exception innerException) : base(message, innerException) { }
    }
}

