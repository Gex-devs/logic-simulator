using Logic_simulator;
using Logic_simulator.Logic_Gates;

public class Program
{
    public static void Main(string[] args)
    {

        //HalfAdderTest();
        //FullAdderTest();
        ConnectionTest();
    }
    private static void ConnectionTest()
    {
        AndGate and = new AndGate();
        NotGate not = new NotGate();
        ORGate oRGate = new ORGate();

        Console.WriteLine("expected result False, True");
        and.SetInput(0, false);
        and.SetInput(1, true);
        Console.WriteLine(and.GetOutput(0));
        and.ConnectOutput(0, not, 0);
        and.ConnectOutput(0, oRGate, 0);
        and.ConnectOutput(0, oRGate, 1);
        Console.WriteLine(not.GetOutput(0));
        Console.WriteLine("-----");

        Console.WriteLine("expected result True, False");
        and.SetInput(0, true);
        Console.WriteLine(and.GetOutput(0));
        Console.WriteLine(not.GetOutput(0));
        Console.WriteLine("-----");

        Console.WriteLine("expected result False, True");
        and.SetInput(1, false);
        Console.WriteLine(and.GetOutput(0));
        Console.WriteLine(not.GetOutput(0));
        Console.WriteLine("-----");

    }
    private static void HalfAdderTest()
    {
        Console.WriteLine("Half Adder Demonstration");
        HalfAdder halfAdder = new HalfAdder();

        Console.WriteLine("expected result False, False");
        // 0 | 0 = 0 | 0
        halfAdder.SetInput(0, false);
        halfAdder.SetInput(1, false);

        Console.WriteLine(halfAdder.GetOutput(0));
        Console.WriteLine(halfAdder.GetOutput(1));
        Console.WriteLine("-----");

        Console.WriteLine("expected result True, False");
        // 0 | 1 = 1 | 0
        halfAdder.SetInput(0, false);
        halfAdder.SetInput(1, true);

        Console.WriteLine(halfAdder.GetOutput(0));
        Console.WriteLine(halfAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result True, False");
        // 1 | 0 = 1 | 0
        halfAdder.SetInput(0, true);
        halfAdder.SetInput(1, false);

        Console.WriteLine(halfAdder.GetOutput(0));
        Console.WriteLine(halfAdder.GetOutput(1));
        Console.WriteLine("-----");

        Console.WriteLine("expected result False, True");

        // 1 | 1 = 0 | 1
        halfAdder.SetInput(0, true);
        halfAdder.SetInput(1, true);

        Console.WriteLine(halfAdder.GetOutput(0));
        Console.WriteLine(halfAdder.GetOutput(1));
        Console.WriteLine("-----");

    }
    private static void FullAdderTest()
    {
        Console.WriteLine("Full Adder Demonstration");
        FullAdder fullAdder = new FullAdder();

        Console.WriteLine("expected result Flase, False");

        // 0 | 0 | 0 = 0 | 0
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, false);
        
        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));
       
        Console.WriteLine("-----");

        Console.WriteLine("expected result True, False");

        // 0 | 0 | 1 = 1 | 0
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, true);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result True, False");

        // 0 | 1 | 0 = 1 | 0
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, false);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result False, True");

        // 0 | 1 | 1 = 0 | 1
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, true);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result True, False");

        // 1 | 0 | 0 = 1 | 0
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, false);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result False, True");

        // 1 | 0 | 1 = 0 | 1
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, true);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result False, True");

        // 1 | 1 | 0 = 0 | 1
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, false);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

        Console.WriteLine("expected result True, True");

        // 1 | 1 | 1 = 1 | 1
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, true);

        Console.WriteLine(fullAdder.GetOutput(0));
        Console.WriteLine(fullAdder.GetOutput(1));

        Console.WriteLine("-----");

    }

}