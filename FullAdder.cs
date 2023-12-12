using Logic_simulator.CustomException;
using Logic_simulator.Logic_Gates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public class FullAdder : ILogicComponent
    {
        private bool[] inputs = new bool[3];
        private bool[] outputs = new bool[2];

        private HalfAdder halfAdder1;
        private HalfAdder halfAdder2;
        private ORGate orGate;

        public FullAdder()
        {
            halfAdder1 = new HalfAdder();
            halfAdder2 = new HalfAdder();
            orGate = new ORGate();
        }

        public bool GetInput(int pin)
        {
            if (pin >= inputs.Length)
            {
                throw new PinOutOfReach();
            }
            return inputs[pin];
        }

        public bool GetOutput(int pin)
        {
            if (pin >= outputs.Length)
            {
                throw new PinOutOfReach();
            }
            ComputeLogic();
            return outputs[pin];
        }

        public void SetInput(int pin, bool value)
        {
            if (pin >= inputs.Length)
            {
                throw new PinOutOfReach();
            }
            inputs[pin] = value;
        }

        public void SetOutput(int pin, bool value)
        {
            if (pin >= outputs.Length)
            {
                throw new PinOutOfReach();
            }
            outputs[pin] = value;
        }

        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            if (outputPin >= outputs.Length)
            {
                throw new PinOutOfReach();
            }
            ComputeLogic(); // Ensure output is computed before connecting
            other.SetInput(inputPin, outputs[outputPin]);
        }

        private void ComputeLogic()
        {
            halfAdder1.SetInput(0, inputs[0]);
            halfAdder1.SetInput(1, inputs[1]);

            halfAdder1.ConnectOutput(0, halfAdder2, 0);
            halfAdder2.SetInput(1, inputs[2]);

            halfAdder1.ConnectOutput(1, orGate, 0);
            halfAdder2.ConnectOutput(1, orGate, 1);

            SetOutput(0, halfAdder2.GetOutput(0));
            SetOutput(1, orGate.GetOutput(0));

        }

    }
}
