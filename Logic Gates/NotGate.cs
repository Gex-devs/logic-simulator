using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_simulator
{
    public class NotGate : ILogicComponent
    {
        public NotGate() { 
        
        }
        
        public void ConnectOutput(int outputPin, ILogicComponent other, int inputPin)
        {
            other.SetInput(inputPin, true);
            throw new NotImplementedException();
        }

        public bool GetInput(int pin)
        {
            throw new NotImplementedException();
        }

        public bool GetOutput(int pin)
        {
            throw new NotImplementedException();
        }

        public void SetInput(int pin, bool value)
        {
            throw new NotImplementedException();
        }
    }
}
