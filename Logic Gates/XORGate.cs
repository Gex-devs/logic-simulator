using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Simulates XOR logic gate
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator.Logic_Gates
{
    public class XORGate : Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 1;

        /// <summary>
        /// Initializes an XORGate with two inputs and one output.
        /// </summary>
        public XORGate() : base(numInputs, numOutputs)
        {
            
        }

        /// <summary>
        /// Computes the logic for the XOR gate.
        /// </summary>
        public override void ComputeLogic()
        {
            // If the inputs are different, set the output to true.
            // Otherwise, if both inputs are the same, set the output to false.
            if (GetInput(0) != GetInput(1))
            {
                SetOutput(0, true);
            }
            else
            {
                SetOutput(0, false);
            }
        }
    }

}
