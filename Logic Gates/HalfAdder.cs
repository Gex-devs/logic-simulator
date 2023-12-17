using Logic_simulator.Logic_Gates;
using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

/*
 *	Description: Simulates HALF adder logic gate
 *
 *	Author : Gedewon Jerene, I519796@fhict.nl
 *	Student number: 519796
 * 	Date: 14 December 2023
 */

namespace Logic_simulator
{
    public class HalfAdder : Gate
    {
        private static readonly int numInputs = 2;
        private static readonly int numOutputs = 2;

        private XORGate xorGate;
        private AndGate andGate;

        /// <summary>
        /// Initializes a HalfAdder by defining the number of inputs and outputs 
        /// and creates XOR and AND gates for internal computation.
        /// </summary>
        public HalfAdder() : base(numInputs, numOutputs)
        {
            xorGate = new XORGate();
            andGate = new AndGate();
        }

        /// <summary>
        /// Computes the logic of the HalfAdder using XOR and AND gates to produce outputs.
        /// </summary>
        public override void ComputeLogic()
        {
            xorGate.SetInput(0, GetInput(0));
            xorGate.SetInput(1, GetInput(1));

            andGate.SetInput(0, GetInput(0));
            andGate.SetInput(1, GetInput(1));

            SetOutput(0, xorGate.GetOutput(0));
            SetOutput(1, andGate.GetOutput(0));
        }

        /// <summary>
        /// Generates a truth table for the HalfAdder logic with different input combinations.
        /// </summary>
        /// <returns>A string containing the truth table for the HalfAdder.</returns>
        public override string GetTruthTable()
        {
            StringBuilder truthTable = new StringBuilder();
            truthTable.AppendLine("Input A | Input B | OutputA | OutputB");
            truthTable.AppendLine("---------------------------");

            bool InputA = false;
            bool InputB = false;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{Convert.ToByte(InputA)}\t  | {Convert.ToByte(InputB)}\t   | {Convert.ToByte(this.GetOutput(0))} | {Convert.ToByte(this.GetOutput(1))}");

            InputA = false;
            InputB = true;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{Convert.ToByte(InputA)}\t  | {Convert.ToByte(InputB)}\t   | {Convert.ToByte(this.GetOutput(0))} | {Convert.ToByte(this.GetOutput(1))}");

            InputA = true;
            InputB = false;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{Convert.ToByte(InputA)}\t   | {Convert.ToByte(InputB)}\t   | {Convert.ToByte(this.GetOutput(0))} | {Convert.ToByte(this.GetOutput(1))}");

            InputA = true;
            InputB = true;
            this.SetInput(0, InputA);
            this.SetInput(1, InputB);
            truthTable.AppendLine($"{Convert.ToByte(InputA)}\t   | {Convert.ToByte(InputB)}\t   | {Convert.ToByte(this.GetOutput(0))} | {Convert.ToByte(this.GetOutput(1))}");

            return truthTable.ToString();
        }
    }


}
