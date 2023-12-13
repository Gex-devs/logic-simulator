using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    public class ORGate : Gate
    {
        private static int inputs = 2;
        private static int outputs = 1;

        public ORGate() : base(inputs, outputs)
        {

        }

        public override void ComputeLogic()
        {
            for (int i = 0; i < inputs; i++)
            {
                if (GetInput(i))
                {
                    SetOutput(0, true);
                    return;
                }
            }
           SetOutput(0, false);
        }

        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
