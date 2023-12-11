using Logic_simulator;
using Logic_simulator.Logic_Gates;
public class Program
{
    public static void Main(string[] args)
    {
        /*
         What does it mean Produce a thruth table for all inputs and outputs?
         Each of the gates should indirectly inherit ??
         */
        HalfAdder halfAdder1 = new HalfAdder();
        HalfAdder halfAdder2 = new HalfAdder();
        ORGate orGate = new ORGate();

        bool inputA = true;
        bool inputB = true;
        bool carryIn = false;

        halfAdder1.SetInput(0, inputA);
        halfAdder1.SetInput(1, inputB);

        halfAdder1.ConnectOutput(0, halfAdder2, 0);
        halfAdder2.SetInput(1, carryIn);

        halfAdder1.ConnectOutput(1, orGate, 0);
        halfAdder2.ConnectOutput(1, orGate, 1);

        // Read the sum and carry outputs
        bool sum = halfAdder2.GetOutput(0);
        bool carryOut = orGate.GetOutput(0);

        Console.WriteLine("Sum Output: " + sum);
        Console.WriteLine("Carry Output: " + carryOut);
    }

}