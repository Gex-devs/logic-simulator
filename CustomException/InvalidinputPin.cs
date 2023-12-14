using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.CustomException
{
    public class InvalidInputPin : LogicGatesException
    {
        private const string defaultMessage = "Input pin out of reach";
        public InvalidInputPin() : base(defaultMessage)
        {

        }

        public InvalidInputPin(string message) : base(message)
        {

        }

        public InvalidInputPin(string message, Exception innerException) : base(message, innerException) { }
    }
}
