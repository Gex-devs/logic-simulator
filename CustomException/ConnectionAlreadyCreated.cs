using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Exception for when attempting to connect the same gate multiple times 
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 * 	Date: 14 December 2023
 */

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

