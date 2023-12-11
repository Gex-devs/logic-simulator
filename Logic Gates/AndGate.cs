using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator.Logic_Gates
{
    public class AndGate: ILogicComponent
    {
        private bool[] inputs = new bool[2];
        private bool[] outputs = new bool[1]; // AndGate has a single output

        public AndGate() { 
        
        }

        public bool GetInput(int pin)
        {
            if (pin < 0 || pin >= inputs.Length)    
            {
                throw new NotImplementedException();
            }
            
            return inputs[pin];
        }

        public bool GetOutput(int pin)
        {
            if (pin < 0 || pin >= inputs.Length)
            {
                throw new NotImplementedException();
            }

            ComputeLogic(pin);
            return outputs[pin];
        }

        public void SetInput(int pin, bool value)
        {
            inputs[pin] = value;
        }
        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            other.SetInput(inputPin, outputs[outputPin]);
        }

        private void ComputeLogic(int pin)
        {
            foreach(bool input in inputs)
            {
                if (!input)
                {
                    outputs[pin] = input;
                    return;
                }
            }
            outputs[pin] = true;
        }

    }
}
