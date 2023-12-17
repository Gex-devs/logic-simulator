using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Simulates OR logic gate
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator.Logic_Gates
{
    public class ORGate : Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 1;

        /// <summary>
        /// Initializes an ORGate with two inputs and one output.
        /// </summary>
        public ORGate() : base(numInputs, numOutputs)
        {
            
        }

        /// <summary>
        /// Computes the logic for the OR Gate by checking if even one of the inputs
        /// is True.
        /// </summary>
        public override void ComputeLogic()
        {
            for (int i = 0; i < numInputs; i++)
            {
                if (GetInput(i)) // found true. set output to true.
                {
                    SetOutput(0, true);
                    return;
                }
            }

            // If no input is true, set the output to false.
            SetOutput(0, false);
        }
    }

}
