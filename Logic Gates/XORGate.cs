using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    public class XORGate : Gate
    {
        private static int inputs = 2;
        private static int outputs = 1;

        public XORGate() : base(inputs, outputs)
        {

        }

        public override void ComputeLogic()
        {
            if (GetInput(0) != GetInput(1))
            {
                SetOutput(0, true);
            }
            else
            {
                SetOutput(0, false);
            }
        }

        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
