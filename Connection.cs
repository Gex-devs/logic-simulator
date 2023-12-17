using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: The Connection class manages the linkage between different logic gates within a system
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
    /// <summary>
    /// Manages the connection between different logic gates within a system by encapsulating connection attributes such as input and output pins and the connected gate.
    /// </summary>
    public class Connection
    {
        private int connectedInputPin;
        private int connectedOutputPin;
        private ILogicComponent connectedGate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection"/> class with specified connection attributes.
        /// </summary>
        /// <param name="connectedInputPin">The input pin of the current gate.</param>
        /// <param name="connectedOutputPin">The output pin of the externally connected gate.</param>
        /// <param name="connectedGate">The gate to which the current gate is connected.</param>
        /// <exception cref="LogicGatesException">Thrown when the connectedGate gate is null.</exception>
        public Connection(int connectedInputPin, int connectedOutputPin, ILogicComponent connectedGate)
        {
            if (connectedGate == null)
            {
                throw new LogicGatesException("Cannot create a connection with a null gate.");
            }

            this.connectedOutputPin = connectedOutputPin;
            this.connectedInputPin = connectedInputPin;
            this.connectedGate = connectedGate;
        }

        /// <summary>
        /// Gets the connected output pin of the externally connected gate.
        /// </summary>
        /// <returns>The connected output pin.</returns>
        public int GetConnectedOutputPin()
        {
            return connectedOutputPin;
        }

        /// <summary>
        /// Gets the connected input pin of the current gate.
        /// </summary>
        /// <returns>The connected input pin.</returns>
        public int GetConnectedInputPin()
        {
            return connectedInputPin;
        }

        /// <summary>
        /// Gets the gate to which the current gate is connected.
        /// </summary>
        /// <returns>The connected gate.</returns>
        public ILogicComponent GetConnectedGate()
        {
            return connectedGate;
        }

        /// <summary>
        /// Updates the value of the connected pin in the connected gate.
        /// </summary>
        /// <param name="value">The boolean value to update the pin with.</param>
        public void Update(bool value)
        {
            connectedGate.SetInput(connectedInputPin, value);
        }
    }

}
