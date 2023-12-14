using Logic_simulator.Logic_Gates;
using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

/*
 *	Description: Simulates HALF adder gate
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
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
            StringBuilder truthTable = new StringBuilder();
            truthTable.AppendLine("Input A | Input B | OutputA | OutputB");
            truthTable.AppendLine("---------------------------");

            bool InputA = false;
            bool InputB = false;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t  | {InputB}\t   | {this.GetOutput(0)} | {this.GetOutput(1)}");

            InputA = false;
            InputB = true;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t  | {InputB}\t   | {this.GetOutput(0)} | {this.GetOutput(1)}");

            InputA = true;
            InputB = false;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t   | {InputB}\t   | {this.GetOutput(0)} | {this.GetOutput(1)}");

            InputA = true;
            InputB = true;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{InputA}\t   | {InputB}\t   | {this.GetOutput(0)} | {this.GetOutput(1)}");

            return truthTable.ToString();
        }

    }

}
