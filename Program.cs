using Logic_simulator;
using Logic_simulator.CustomException;
using Logic_simulator.Logic_Gates;

public class Program
{
    public static void Main(string[] args)
    {

        AndGate And = new AndGate();
        ORGate OR = new ORGate();
        NotGate notGate = new NotGate();
        XORGate XORGate = new XORGate();
        FullAdder fullAdder = new FullAdder();
        HalfAdder halfAdder = new HalfAdder();

        try
        {
            Console.WriteLine("AND gate truth table");
            Console.WriteLine("=====================");
            Console.WriteLine(And.GetTruthTable());

            Console.WriteLine("OR gate truth table");
            Console.WriteLine("=====================");
            Console.WriteLine(OR.GetTruthTable());

            Console.WriteLine("NOT gate truth table");
            Console.WriteLine("=====================");
            Console.WriteLine(notGate.GetTruthTable());

            Console.WriteLine("XOR gate truth table");
            Console.WriteLine("=====================");
            Console.WriteLine(XORGate.GetTruthTable());

            Console.WriteLine("Full adder gate truth table");
            Console.WriteLine("=====================");
            Console.WriteLine(fullAdder.GetTruthTable());

            Console.WriteLine("Half adder gate truth table");
            Console.WriteLine("=====================");
            Console.WriteLine(halfAdder.GetTruthTable());

            Console.WriteLine("Connection Test");
            Console.WriteLine("=====================");
            ConnectionTest();
        }
        catch (ConnectionAlreadyCreated ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidInputPin ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOutputPin ex)
        {
            Console.WriteLine(ex.Message);
        }
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
}