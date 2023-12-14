using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.CustomException
{
    public class InvalidOutputPin : LogicGatesException
    {
        private const string defaultMessage = "Output pin out of reach";
        public InvalidOutputPin() : base(defaultMessage)
        {

        }

        public InvalidOutputPin(string message) : base(message)
        {

        }

        public InvalidOutputPin(string message, Exception innerException) : base(message, innerException) { }
    }
}
