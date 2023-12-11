using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.CustomException
{
    public class PinOutOfReach : LogicGatesException
    {
        private const string defaultMessage = "pin out of reach";
        public PinOutOfReach() : base(defaultMessage)
        {


        }

        public PinOutOfReach(string message) : base(message)
        {

        }

        public PinOutOfReach(string message, Exception innerException) : base(message, innerException) { }
    }
}
