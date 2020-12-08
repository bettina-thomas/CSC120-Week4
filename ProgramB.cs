using LogicCircuit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Program
    {
        static void Main(string[] args)
        {

            var orGate = new OR();
            var andGate = new AND();
            var notGate = new NOT();
            notGate.SetInputA(false);
            andGate.SetInputA(true);
            andGate.SetInputB(true);
            var restOfAndGate = andGate.Output.State;
            orGate.SetInputA(true);
            orGate.SetInputB(restOfAndGate);
            var result = orGate.Output.State;
            var result2 = notGate.Output.State;
            //List<IndentityInput> inputs = BuildtruthTable();
            var inputs = new List<IndentityInput>();
            inputs.Add(new IndentityInput() { X = false, Y = false });
            inputs.Add(new IndentityInput() { X = false, Y = true });
            inputs.Add(new IndentityInput() { X = true, Y = false });
            inputs.Add(new IndentityInput() { X = true, Y = true });
            

            // Step 1 complete the rest of the input through table values

            // Step 2 now loop through each item rown in the truth table
            ProcessLogicGates(inputs);
            foreach (var item in inputs)
            {

                var identity = new Identity();

                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;

                //var output = identity.Validate();
                Console.WriteLine($" A = {identity.SetInputX}," +
                    $" B = {identity.SetInputY}, " +
                    $" OutPut= {output}");
                //var resutOfAndGate = identity.Output;
            }
            
            //x + y  = x * y, x * y = x + y 
            Console.ReadLine();

        }

        private static void ProcessLogicGates(List<IndentityInput> inputs)
        {
            foreach (var item in inputs)
            {

                var identity = new Identity();

                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;

                var output = identity.Validate();
                Console.WriteLine($" A = {identity.SetInputX}," +
                    $" B = {identity.SetInputY}, " +
                    $" OutPut= {output}");
                var resutOfAndGate = identity.Output;
            }
        }

        private static List<IndentityInput> BuildtruthTable()
        {
            var inputs = new List<IndentityInput>();
            inputs.Add(new IndentityInput() { X = false, Y = false });
            inputs.Add(new IndentityInput() { X = false, Y = true });
            inputs.Add(new IndentityInput() { X = true, Y = false });
            inputs.Add(new IndentityInput() { X = true, Y = true });
            return inputs;
        }

        class Identity
        {
            public bool SetInputX { get; set; }

            public bool SetInputY { get; set; }

            public bool Output { get; set; }

           /* public bool Validate()
            {
                var result = true;
                /*if (SetInputX == SetInputY)
                {
                    if (SetInputX == true) 
                    { return true; }
                    else { return false; }
                }*/
                /*var tester = new AND();
                tester.SetInputA(true);
                tester.SetInputB(true);
                result = tester.Output;

                return result;*/

            }*/
        }
        internal class IndentityInput
        {

            public bool X { get; set; }
            public bool Y { get; set; }

        }
    }
}

