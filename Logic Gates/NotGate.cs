using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    /// <summary>
    /// Simulates the NOT gate logic
    /// </summary>
    public class NotGate : Gate
    {
        private static readonly int numInputs = 1;
        private static readonly int numOutputs = 1;
        /// <summary>
        /// Intalizes the number of inputs and outputs
        /// </summary>
        public NotGate() : base(numInputs, numOutputs) { 
        
        }
        /// <summary>
        /// Computes the logic for the and gate
        /// </summary>
        public override void ComputeLogic()
        {
            SetOutput(0,!GetInput(0));
        }
        /// <summary>
        /// Creates a truth table using the Not Gate logic
        /// </summary>
        /// <returns></returns>
        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
