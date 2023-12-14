using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    /// <summary>
    /// Class used to store the connection to a gate
    /// </summary>
    public class Connection
    {
        private int connectedPin;
        private int outputPin;
        private ILogicComponent connectedGate;
        /// <summary>
        /// Stores the connection attributes to the class
        /// </summary>
        /// <param name="connectedPin"> input pin of the current gatess</param>
        /// <param name="outputPin">the output pin of the external connected gate</param>
        /// <param name="connectedGate">the gate to connect to</param>
        public Connection(int connectedPin, int outputPin, ILogicComponent connectedGate)
        {
            this.outputPin = outputPin;
            this.connectedPin = connectedPin;   
            this.connectedGate = connectedGate;
        }
        /// <summary>
        /// Gets the connected output pin
        /// </summary>
        /// <returns>connected output pin</returns>
        public int GetConnectedOutputPin()
        {
            return outputPin;
        }
        /// <summary>
        /// Gets the connected input pin
        /// </summary>
        /// <returns>connected input pin</returns>
        public int GetConnectedPin()
        {
            return connectedPin;
        }
        /// <summary>
        /// Gets the connected gate
        /// </summary>
        /// <returns>the connected gate</returns>
        public ILogicComponent GetConnectedGate()
        {
            return connectedGate;
        }
        /// <summary>
        /// Updates the value of the connected pin in the gate
        /// </summary>
        /// <param name="value">boolean value of to update the pin with</param>
        public void Update(bool value)
        {
            connectedGate.SetInput(connectedPin, value);
        }

    }
}
