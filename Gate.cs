using Logic_simulator.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public abstract class Gate : ILogicComponent
    {
        private bool[] inputs;
        private bool[] outputs;
        List<Tuple<int,int,ILogicComponent>> Connections = new List<Tuple<int, int, ILogicComponent>>();
        public abstract void ComputeLogic();
        public abstract string GetTruthTable();

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
            Update(pin);
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
            other.SetInput(inputPin, outputs[outputPin]);
            Tuple<int,int,ILogicComponent> connection = Tuple.Create(inputPin, outputPin, other);
            Connections.Add(connection);
        }

        public void Update(int pin)
        {
            foreach(var connection in Connections)
            {
                connection.Item3.SetInput(pin, GetOutput(connection.Item2));
            }
        }

    }
}
