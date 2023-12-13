using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public class NotGate : Gate
    {
        private static int inputs = 1;
        private static int outputs = 1;
        public NotGate() : base(inputs, outputs) { 
        
        }

        public override void ComputeLogic()
        {
            SetOutput(0,!GetInput(0));
        }

        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
