using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    public class ORGate : ILogicComponent
    {
        private bool[] inputs = new bool[2];
        private bool[] outputs = new bool[1]; // AndGate has a single output

        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            ComputeLogic();
            other.SetInput(inputPin, outputs[outputPin]);
        }

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
        
        private void ComputeLogic()
        {
            foreach (bool inputPin in inputs)
            {
                if (inputPin)
                {
                    outputs[0] = inputPin;
                    return;
                }
            }

            outputs[0] = false;
        }
    }
}
