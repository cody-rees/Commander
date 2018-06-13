using Commander;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderTests {
    class Program {
        static void Main(string[] startArgs) {
            var commander = new CommanderCLI();

            while (commander.ReadLine(out string[] args, out string[] flags)) {
                Console.WriteLine("Arguments: ");
                Console.WriteLine(string.Join("\n", args.Select(arg => $@"- ""{arg}""")));


                Console.WriteLine("Flags: ");
                Console.WriteLine(string.Join("\n", flags.Select(flag => $@"- ""{flag}""")));
            }

            Console.WriteLine("GoodBye");
        }
    }
}
