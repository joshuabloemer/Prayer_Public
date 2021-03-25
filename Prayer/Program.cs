using System;
using System.IO;

namespace Prayer
{
    class Program
    {
        static void Main(string[] args){
            string program = args[0];
            var source = File.ReadAllText(program);
            var parser = new Parsers.Parser();
            var syntax = parser.Parse(source);
            var evaluator = new Evaluator();

            //Console.WriteLine("==== SYNTAX ====");
            //Console.WriteLine(syntax.PrettyPrint());
            //Console.WriteLine("==== OUTPUT ====");
            evaluator.run(syntax,program);
        
        
        }
    }
}
