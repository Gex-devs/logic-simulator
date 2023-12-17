using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: logic gate exception for invlaid input pin 
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

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
