using Logic_simulator;
using Logic_simulator.Logic_Gates;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         What does it mean Produce a thruth table for all inputs and outputs?
         */

        DemonstrateHalfAdder();
        DemonstrateFullAdder();
    }



    private static void DemonstrateHalfAdder()
    {
        Console.WriteLine("Half Adder Demonstration");
        HalfAdder halfAdder = new HalfAdder();

        // 0 | 0 = 0 | 0
        halfAdder.SetInput(0, false);
        halfAdder.SetInput(1, false);

        if (halfAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (halfAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 0 | 1 = 1 | 0
        halfAdder.SetInput(0, false);
        halfAdder.SetInput(1, true);

        if (halfAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (halfAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 1 | 0 = 1 | 0
        halfAdder.SetInput(0, true);
        halfAdder.SetInput(1, false);

        if (halfAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (halfAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }


        // 1 | 1 = 0 | 1
        halfAdder.SetInput(0, true);
        halfAdder.SetInput(1, true);

        if (halfAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (halfAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

    }
    private static void DemonstrateFullAdder()
    {
        Console.WriteLine("Full Adder Demonstration");
        FullAdder fullAdder = new FullAdder();

        // 0 | 0 | 0 = 0 | 0
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, false);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 0 | 0 | 1 = 1 | 0
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, true);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 0 | 1 | 0 = 1 | 0
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, false);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 0 | 1 | 1 = 0 | 1
        fullAdder.SetInput(0, false);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, true);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 1 | 0 | 0 = 1 | 0
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, false);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 1 | 0 | 1 = 0 | 1
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, false);
        fullAdder.SetInput(2, true);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 1 | 1 | 0 = 0 | 1
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, false);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

        // 1 | 1 | 1 = 1 | 1
        fullAdder.SetInput(0, true);
        fullAdder.SetInput(1, true);
        fullAdder.SetInput(2, true);

        if (fullAdder.GetOutput(0))
        {
            Console.Write("T|");
        }
        else
        {
            Console.Write("F|");
        }

        if (fullAdder.GetOutput(1))
        {
            Console.Write("T\n");
        }
        else
        {
            Console.Write("F\n");
        }

    }

}