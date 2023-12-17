using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: General logic gate exception 
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator.CustomException
{
    public class LogicGatesException : Exception
    {
        private const string defaultMessage = "Invalid logic gate";
        public LogicGatesException() : base(defaultMessage)
        {


        }

        public LogicGatesException(string message) : base(message)
        {

        }

        public LogicGatesException(string message, Exception innerException) : base(message, innerException) { }



    }

}

