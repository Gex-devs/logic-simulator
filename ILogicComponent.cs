using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public interface ILogicComponent
    {
        // Returns the state of an input pin.
        bool GetInput(int pin);
        // Returns the state of an output in.
        bool GetOutput(int pin);
        // Set the state of an input pin.
        void SetInput(int pin, bool value);
        // Connect an output of this component to an input of another component.
        // Allows multiple connections from the same output to other output pins
        void ConnectOutput(int outputPin, ILogicComponent other, int inputPin);
    }
}
