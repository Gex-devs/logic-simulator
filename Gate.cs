using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Base Class gate to simulate logic gates
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
    public abstract class Gate : ILogicComponent
    {
        private bool[] inputs;
        private bool[] outputs;
        List<Connection> connections;

        /// <summary>
        /// Compute logic for the component
        /// </summary>
        public abstract void ComputeLogic();

       
        /// <summary>
        /// Intializes the connection List and 
        /// the number of inputs and outputs for the child Gate
        /// </summary>
        /// <param name="numberOfInputs"> the number of inputs for the gate</param>
        /// <param name="numberOfOutputs">the umber of outputs for the gate</param>
        public Gate(int numberOfInputs, int numberOfOutputs)
        {
            connections = new List<Connection>();

            inputs = new bool[numberOfInputs];
            outputs = new bool[numberOfOutputs];
        }

        /// <summary>
        /// Get an input pin of the gate
        /// </summary>
        /// <param name="pin">input pin to retrieve</param>
        /// <returns></returns>
        /// <exception cref="InvalidInputPin">The input pin doesn't exist</exception>
        public bool GetInput(int pin)
        {
            if ((pin < 0) || (pin >= inputs.Length))
            {
                throw new InvalidInputPin();
            }
            return inputs[pin];
        }

        /// <summary>
        /// Get an Output pin of the gate
        /// </summary>
        /// <param name="pin">Output pin to retrieve</param>
        /// <returns></returns>
        /// <exception cref="InvalidOutputPin">The Output pin doesn't exist</exception>
        public bool GetOutput(int pin)
        {
            if ((pin < 0) || (pin >= inputs.Length))
            {
                throw new InvalidOutputPin();
            }
            ComputeLogic();
            return outputs[pin];
        }

        /// <summary>
        /// Set value of an input pin to True or False
        /// </summary>
        /// <param name="pin">input pin to set</param>
        /// <param name="value">The boolean value to set to the pin</param>
        /// <exception cref="InvalidInputPin">The Input pin doesn't Exist</exception>
        public void SetInput(int pin, bool value)
        {
            if ((pin < 0) || (pin >= inputs.Length))
            {
                throw new InvalidInputPin();
            }
            inputs[pin] = value;
            UpdateAllConnections(); // Output changes when input changes. Update all connections with the new output value.
        }

        /// <summary>
        /// Set value of an Output pin to True or False
        /// </summary>
        /// <param name="pin">Output pin to set</param>
        /// <param name="value">The boolean value to set to the pin</param>
        /// <exception cref="InvalidOutputPin">The Output pin doesn't Exist</exception>
        public void SetOutput(int pin, bool value)
        {
            if ((pin < 0) || (pin >= inputs.Length))
            {
                throw new InvalidOutputPin();
            }
            outputs[pin] = value;
        }

        /// <summary>
        /// Connect an output of this component to an input of another component.
        /// </summary>
        /// <param name="outputPin">Outpin to get the value from</param>
        /// <param name="other">The component to connect to</param>
        /// <param name="inputPin">the components input pin to set to</param>
        /// <exception cref="InvalidOutputPin">The input pin doesn't exist</exception>
        /// <exception cref="ConnectionAlreadyCreated">Connection already exists</exception>
        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            if ((outputPin < 0) || (outputPin >= outputs.Length))
            {
                throw new InvalidOutputPin();
            }

            foreach (Connection connection in connections)
            {
                if (connection.GetConnectedOutputPin() == outputPin && connection.GetConnectedPin() == inputPin && connection.GetConnectedGate() == other)
                {
                    throw new ConnectionAlreadyCreated();
                }
            }

            ComputeLogic(); // Ensure output is computed before connecting
            other.SetInput(inputPin, outputs[outputPin]);

            // Create connection instance and add to the list
            Connection newConnection = new Connection(inputPin, outputPin, other);
            connections.Add(newConnection);
        }

        /// <summary>
        /// Updates all connection of the current components with the latest output value
        /// </summary>
        private void UpdateAllConnections()
        {
            if (connections.Count > 0) // Update only if there's one or more connection
            {
                foreach (Connection connection in connections)
                {
                    connection.Update(GetOutput(connection.GetConnectedOutputPin())); // Update with the Latest output from connected pin
                }
            }

        }

        /// <summary>
        /// Creates truth table for the Common logic gates
        /// </summary>
        /// <returns>truth table</returns>
        public virtual string GetTruthTable() {
            StringBuilder truthTable = new StringBuilder();
            truthTable.AppendLine("Input A | Input B | Output");
            truthTable.AppendLine("---------------------------");

            bool InputA = false;
            bool InputB = false;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t   | {InputB}\t   | {this.GetOutput(0)}");

            InputA = false;
            InputB = true;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t   | {InputB}\t   | {this.GetOutput(0)}");

            InputA = true;
            InputB = false;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t   | {InputB}\t   | {this.GetOutput(0)}");

            InputA = true;
            InputB = true;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t   | {InputB}\t   | {this.GetOutput(0)}");

            return truthTable.ToString();
        }

    }
}
