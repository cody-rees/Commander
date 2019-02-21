using Commander;
using System;
using System.Linq;

namespace CommanderTests {
    class Program {
        static void Main(string[] startArgs) {
            var commander = new CommanderCLI() {
                ParseUnescapedNullsAsNull = true
            };
            string prefix = "commander> ";

            Console.Write(prefix);
            while (commander.ReadLine(out string[] args, out string[] flags)) {
                Console.WriteLine("Arguments: ");
                Console.WriteLine(string.Join("\n", args.Select(arg => $@"- ""{arg}""")));


                Console.WriteLine("Flags: ");
                Console.WriteLine(string.Join("\n", flags.Select(flag => $@"- ""{flag}""")));


                Console.Write(prefix);
            }

            Console.WriteLine("GoodBye");
        }
    }
}
