using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public abstract class Gate : ILogicComponent
    {
        private bool[] inputs;
        private bool[] outputs;
        List<int> connectedPins = new List<int>();
        public abstract void ComputeLogic();

        public Gate(int numberOfInputs, int numberOfOutputs)
        {
            inputs = new bool[numberOfInputs];
            outputs = new bool[numberOfOutputs];
        }

        public bool GetInput(int pin)
        {
            if (pin < 0 || pin >= inputs.Length)
            {
                throw new PinOutOfReach();
            }

            return inputs[pin];
        }

        public bool GetOutput(int pin)
        {
            if (pin < 0 || pin >= inputs.Length)
            {
                throw new PinOutOfReach();
            }
            ComputeLogic();
            return outputs[pin];
        }

        public void SetInput(int pin, bool value)
        {
            if (pin < 0 || pin >= inputs.Length)
            {
                throw new PinOutOfReach();
            }
            
            inputs[pin] = value;
        }
        public void SetOutput(int pin, bool value)
        {
            if (pin < 0 || pin >= inputs.Length)
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

            if (connectedPins.Contains(outputPin))
            {
                throw new ConnectionAlreadyCreated();
            }

            connectedPins.Add(outputPin);
            other.SetInput(inputPin, outputs[outputPin]);
        }

       
    }
}
