using Logic_simulator.Logic_Gates;
using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Logic_simulator
{
    /// <summary>
    /// Simulates Half adder logic gate
    /// </summary>
    public class HalfAdder : Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 2;

        private XORGate XORgate;
        private AndGate Andgate;
        /// <summary>
        /// Intializes the gate and sends the number of inputs and outputs of 
        /// the gate
        /// </summary>
        public HalfAdder() : base(numInputs, numOutputs)
        {
            XORgate = new XORGate();
            Andgate = new AndGate();
        }
        /// <summary>
        /// Computes the logic gate
        /// </summary>
        public override void ComputeLogic()
        {
            XORgate.SetInput(0, GetInput(0));
            XORgate.SetInput(1, GetInput(1));

            Andgate.SetInput(0, GetInput(0));
            Andgate.SetInput(1, GetInput(1));

            SetOutput(0, XORgate.GetOutput(0));
            SetOutput(1, Andgate.GetOutput(0));
        }
        /// <summary>
        /// Using the half adders compute logic. it creates a truth table
        /// </summary>
        /// <returns>truth table</returns>
        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }

    }

}
