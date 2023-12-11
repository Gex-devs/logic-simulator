using Logic_simulator.Logic_Gates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public class HalfAdder : ILogicComponent
    {
        private bool[] inputs = new bool[2];
        private bool[] outputs = new bool[2];

        private XORGate XORgate;
        private AndGate Andgate;

        public HalfAdder()
        {
            XORgate = new XORGate();
            Andgate = new AndGate();
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

        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            ComputeLogic(); // Ensure output is computed before connecting
            other.SetInput(inputPin, outputs[outputPin]);
        }

        private void ComputeLogic()
        {
            XORgate.SetInput(0, inputs[0]);
            XORgate.SetInput(1, inputs[1]);

            Andgate.SetInput(0, inputs[0]);
            Andgate.SetInput(1, inputs[1]);

            outputs[0] = XORgate.GetOutput(0);
            outputs[1] = Andgate.GetOutput(0);
        }
    }

}
