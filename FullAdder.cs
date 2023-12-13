using Logic_simulator.CustomException;
using Logic_simulator.Logic_Gates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public class FullAdder : Gate
    {
        private static int inputs = 3;
        private static int outputs = 2;

        private HalfAdder halfAdder1;
        private HalfAdder halfAdder2;
        private ORGate orGate;  

        public FullAdder() : base(inputs, outputs)
        {
            
            halfAdder1 = new HalfAdder();
            halfAdder2 = new HalfAdder();
            orGate = new ORGate();

            halfAdder1.ConnectOutput(0, halfAdder2, 0);
            halfAdder1.ConnectOutput(1, orGate, 0);
            halfAdder2.ConnectOutput(1, orGate, 1);
        }
        public override void ComputeLogic()
        {
            halfAdder1.SetInput(0, GetInput(0));
            halfAdder1.SetInput(1, GetInput(1));

            halfAdder2.SetInput(1, GetInput(2));

            SetOutput(0, halfAdder2.GetOutput(0));
            SetOutput(1, orGate.GetOutput(0));
        }

        public override string GetTruthTable()
        {
            throw new NotImplementedException();
        }
    }
}
