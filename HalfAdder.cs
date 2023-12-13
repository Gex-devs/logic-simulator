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
    public class HalfAdder : Gate
    {
        private static int inputs = 2;
        private static int outputs = 2;

        private XORGate XORgate;
        private AndGate Andgate;
        public HalfAdder() : base(inputs, outputs)
        {
            XORgate = new XORGate();
            Andgate = new AndGate();
        }

        public override void ComputeLogic()
        {
            XORgate.SetInput(0, GetInput(0));
            XORgate.SetInput(1, GetInput(1));

            Andgate.SetInput(0, GetInput(0));
            Andgate.SetInput(1, GetInput(1));

            SetOutput(0, XORgate.GetOutput(0));
            SetOutput(1, Andgate.GetOutput(0));
        }

        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }

    }

}
