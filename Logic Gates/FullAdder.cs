using Logic_simulator.CustomException;
using Logic_simulator.Logic_Gates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Simulates FullAdder logic gate
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
    public class FullAdder : Gate
    {
        private static readonly int numInputs = 3;
        private static readonly int numOutputs = 2;

        private HalfAdder halfAdder1;
        private HalfAdder halfAdder2;
        private ORGate orGate;

        /// <summary>
        /// Initializes a FullAdder by creating two HalfAdders and an ORGate 
        /// and establishing the necessary connections to perform full adder logic.
        /// </summary>
        public FullAdder() : base(numInputs, numOutputs)
        {
            // Initialize the gates
            halfAdder1 = new HalfAdder();
            halfAdder2 = new HalfAdder();
            orGate = new ORGate();

            // Establish connections between gates
            halfAdder1.ConnectOutput(0, halfAdder2, 0);
            halfAdder1.ConnectOutput(1, orGate, 0);
            halfAdder2.ConnectOutput(1, orGate, 1);
        }

        /// <summary>
        /// Computes the FullAdder logic by setting inputs and reading outputs from connected gates.
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
        /// Generates a truth table for the FullAdder logic with different input combinations.
        /// </summary>
        /// <returns>A string containing the truth table for the FullAdder.</returns>
        public override string GetTruthTable()
        {
            // Create a StringBuilder to store the truth table
            StringBuilder truthTable = new StringBuilder();
            truthTable.AppendLine("Input A | Input B | Input C | OutputA | OutputB");
            truthTable.AppendLine("----------------------------------------------");

            // Iterate through different input combinations and record outputs
            for (int i = 0; i < 8; i++)
            {
                bool inputA = (i & 0b100) != 0;
                bool inputB = (i & 0b010) != 0;
                bool inputC = (i & 0b001) != 0;

                this.SetInput(0, inputA);
                this.SetInput(1, inputB);
                this.SetInput(2, inputC);

                truthTable.AppendLine($"{Convert.ToByte(inputA)}\t   | {Convert.ToByte(inputB)}\t  | {Convert.ToByte(inputC)}\t | {Convert.ToByte(this.GetOutput(0))}\t  | {Convert.ToByte(this.GetOutput(1))}");
            }

            return truthTable.ToString();
        }
    }

}
