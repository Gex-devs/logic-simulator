using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    /// <summary>
    /// Simulate the XOR gate logic
    /// </summary>
    public class XORGate : Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 1;
        /// <summary>
        /// Intializes the number of inputs and outputs
        /// </summary>
        public XORGate() : base(numInputs, numOutputs)
        {

        }
        /// <summary>
        /// Computes the logic for the OR gate
        /// </summary>
        public override void ComputeLogic()
        {
            if (GetInput(0) != GetInput(1))
            {
                SetOutput(0, true);
            }
            else
            {
                SetOutput(0, false);
            }
        }
        /// <summary>
        /// Creates a truth table using the XOR Gate
        /// </summary>
        /// <returns>truth table</returns>
        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
