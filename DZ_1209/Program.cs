using DZ_1209;
using static System.Console;

namespace DC_1209
{
    public delegate void ArrayToolBox(decimal[] array);

    class Program
    {
        static public void Main()
        {
            decimal[] arrForTools = new decimal[10];
            ArrayTools arrTool = new ArrayTools();

            ArrayToolBox arrToolBox = new(arrTool.evenOutput);

            arrToolBox += arrTool.oddOutput;
            arrToolBox += arrTool.primeOutput;
            arrToolBox += arrTool.fibonachiOutput;

            // WriteLine("TEST_1");
            for (int x = 0; x < 10; x++)
            {
                // WriteLine("TEST_2");
                arrForTools[x] = (new Random()).Next(100);
                // Console.Write(arrForTools[x] + " ");
            }

            arrToolBox(arrForTools);
        }
    }
}