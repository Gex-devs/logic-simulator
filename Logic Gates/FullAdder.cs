using Logic_simulator.CustomException;
using Logic_simulator.Logic_Gates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    /// <summary>
    /// Simulates a Full adder gate logic
    /// </summary>
    public class FullAdder : Gate
    {
        private static readonly int numInputs = 3;
        private static readonly int numOutputs = 2;

        private HalfAdder halfAdder1;
        private HalfAdder halfAdder2;
        private ORGate orGate;  
        /// <summary>
        /// Intlizes the two HALF adder gates and the OR gate 
        /// and creates the neccary conneections to perform the
        /// full adder logic
        /// </summary>
        public FullAdder() : base(numInputs, numOutputs)
        {
            // Intlaizes all the gates
            halfAdder1 = new HalfAdder();
            halfAdder2 = new HalfAdder();
            orGate = new ORGate();

            // Connect all the appropriate pins
            halfAdder1.ConnectOutput(0, halfAdder2, 0);
            halfAdder1.ConnectOutput(1, orGate, 0);
            halfAdder2.ConnectOutput(1, orGate, 1);
        }
        /// <summary>
        /// Computes the Full adder logic
        /// </summary>
        public override void ComputeLogic()
        {
            halfAdder1.SetInput(0, GetInput(0));
            halfAdder1.SetInput(1, GetInput(1));

            halfAdder2.SetInput(1, GetInput(2));

            SetOutput(0, halfAdder2.GetOutput(0));
            SetOutput(1, orGate.GetOutput(0));
        }
        /// <summary>
        /// Creates a truth table with Full adder logic
        /// </summary>
        /// <returns>returns the truth table for full adder</returns>
        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
