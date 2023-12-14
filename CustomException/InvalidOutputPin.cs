using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: logic gate exception for invalid output pin 
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 * 	Date: 14 December 2023
 */

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
