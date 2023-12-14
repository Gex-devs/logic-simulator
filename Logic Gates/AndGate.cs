using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    /// <summary>
    /// Simulates the AND gate logic
    /// </summary>
    public class AndGate: Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 1;
        /// <summary>
        /// Intializes the number of inputs and outputs of the gate
        /// </summary>
        public AndGate() : base(numInputs, numOutputs)
        { 
            
        }
        /// <summary>
        /// Computes the logic for AND gate
        /// </summary>
        public override void ComputeLogic()
        {
            for (int i = 0; i < numInputs; i++)
            {
                if (!GetInput(i))
                {
                    SetOutput(0, false);
                    return;
                }
            }
            SetOutput(0, true);
        }
        /// <summary>
        /// Creates table using AND gate logic
        /// </summary>
        /// <returns>truth table</returns>
        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
