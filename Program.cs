using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreCalculator
{
     class Program
    {
        
        static void Main(string[] args)
        {
            
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.rollResult = ReadInt(calculator.rollResult, "Starting 4d6 roll");
                calculator.DvideBy = ReadDouble(calculator.DvideBy, "Dvide by");
                calculator.Amount = ReadInt(calculator.Amount, "add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "minumum");
                calculator.CalculateAbilityScore ();
                Console.WriteLine("calculated ability score"+calculator.score);
                Console.WriteLine("press Q to quit, any other key to contuniu" );
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }
        static int ReadInt(int lastUsedValue,string prompt)
        {
            Console.Write(prompt +"["+lastUsedValue+"]:");
            string line = Console.ReadLine();
            if(int.TryParse(line, out int value))
            {
                Console.WriteLine(" using value"+value);
                return value;
            }
            else
            {
                Console.WriteLine("   using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        static double ReadDouble(double lastUsedValue,string prompt)
        {
            Console.Write(prompt + "[" + lastUsedValue + "]:");
            string line = Console.ReadLine();
            if(double.TryParse(line,out double value))
            {
                Console.WriteLine("  using value" + value);
                return value;
            }
            else
            {
                Console.WriteLine("   using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
        
    }
  
}
