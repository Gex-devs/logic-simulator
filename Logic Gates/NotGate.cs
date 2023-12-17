using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Simulates NOT logic gate 
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
    public class NotGate : Gate
    {
        private static readonly int numInputs = 1;
        private static readonly int numOutputs = 1;

        /// <summary>
        /// Initializes a NotGate with a single input and output.
        /// </summary>
        public NotGate() : base(numInputs, numOutputs) { }

        /// <summary>
        /// Computes the logic for the NOT gate by inverting the input.
        /// </summary>
        public override void ComputeLogic()
        {
            SetOutput(0, !GetInput(0));
        }

        /// <summary>
        /// Generates a truth table using the NOT Gate logic.
        /// </summary>
        /// <returns>A string containing the truth table for the NOT Gate.</returns>
        public override string GetTruthTable()
        {
            StringBuilder truthTable = new StringBuilder();
            truthTable.AppendLine("Input A\t  | Output");
            truthTable.AppendLine("---------------------------");

            bool InputA = true;
            this.SetInput(0, InputA);
            truthTable.AppendLine($"{InputA}\t  | {this.GetOutput(0)}");

            InputA = false;
            this.SetInput(0, InputA);
            truthTable.AppendLine($"{InputA}\t  | {this.GetOutput(0)}");

            return truthTable.ToString();
        }
    }

}
