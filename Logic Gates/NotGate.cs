using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	Description: Simulates NOT logic gate 
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
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
