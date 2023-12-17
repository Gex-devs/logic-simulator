using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Simulates AND gate
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator.Logic_Gates
{
    public class AndGate : Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 1;

        /// <summary>
        /// Initializes an instance of the AndGate class with a specific number of inputs and outputs.
        /// </summary>
        public AndGate() : base(numInputs, numOutputs)
        {

        }

        /// <summary>
        /// Computes the logical AND operation for the AndGate based on its inputs.
        /// </summary>
        public override void ComputeLogic()
        {
            /// Sets the output to true if all inputs are true; otherwise, sets the output to 'false'.
            // Iterate through each input to perform the AND operation
            for (int i = 0; i < numInputs; i++)
            {
                // If any input is false, set the output to false and exit the loop/method
                if (!GetInput(i))
                {
                    SetOutput(0, false);
                    return;
                }
            }

            // All inputs are 'true', set the output to 'true'
            SetOutput(0, true);
        }
    }

}
