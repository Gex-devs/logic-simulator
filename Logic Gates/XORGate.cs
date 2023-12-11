using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    public class XORGate : ILogicComponent
    {
        private bool[] inputs = new bool[2];
        private bool[] outputs = new bool[1];

        public bool GetInput(int pin)
        {
            return inputs[pin];
        }

        public bool GetOutput(int pin)
        {
            ComputeLogic();
            return outputs[pin];
        }

        public void SetInput(int pin, bool value)
        {
            inputs[pin] = value;
        }

        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            ComputeLogic();
            other.SetInput(inputPin, outputs[outputPin]);
        }

        private void ComputeLogic()
        {
            if (inputs[0] != inputs[1])
            {
                outputs[0] = true;
                return;
            }
            outputs[0] = false;
        }

    }
}
