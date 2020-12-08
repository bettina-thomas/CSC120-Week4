using LogicCircuit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = true, X = true });
            inputs.Add(new IdentityInput() { A = false, D = true, X = true });
            inputs.Add(new IdentityInput() { A = true, D = false, X = true });
            inputs.Add(new IdentityInput() { A = true, D = false, X = false });
            inputs.Add(new IdentityInput() { A = true, D = true, X = true });
            inputs.Add(new IdentityInput() { A = true, D = true, X = true });

            var andGate = new AND();

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputD = item.D;
                identity.SetInputA = item.A;
                identity.SetInputX = item.X;

                var output = identity.Validate();
                Console.WriteLine($" D = {identity.SetInputD }," +
                    $" A = {identity.SetInputA}, " +
                   $" X= { identity.SetInputX}, " +
                   $"OutPut = {output}");
            }
            Console.ReadLine();
        }
        class IdentityInput
        {
            public bool D { get; set; }
            public bool A { get; set; }
            public bool X { get; set; }

        }
        class Identity
        {
            public bool SetInputD { get; set; }
            public bool SetInputA { get; set; }
            public bool SetInputX { get; set; }
            bool result;
            public bool Validate()
            { //var result;
                if
                (result == true)


                { return result; }
                else
                    return false;

                //Console.Read();
            }
            //Console.ReadKey(true);
                
        }
        //Console.Read();
    }
}
