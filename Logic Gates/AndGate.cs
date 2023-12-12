using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    public class AndGate: Gate
    {
        private static int inputs = 2;
        private static int outputs = 1;
        public AndGate() : base(inputs, outputs){ 
            
        }
        public override void ComputeLogic()
        {
            for (int i = 0; i < inputs; i++)
            {
                if (!GetInput(i))
                {
                    SetOutput(0, false);
                    return;
                }
            }
            SetOutput(0, true);
        }
    }
}
