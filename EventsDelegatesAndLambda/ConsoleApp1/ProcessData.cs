using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class ProcessData
    {
        // what we want to do, is to add x and y, or multiply x and y or whatever function we need
        // and we do not need to hardcode that logic inside of this, i want to pass the business role
        // i want to pass the role of how to process x and y
        public void Process(int x, int y, BizRulesDelegate del)
        {
            // we are not hardcoding on what to do with x and y
            // i passed it using the delegate
            var result = del(x, y);
            Console.WriteLine(result);
        }

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed");
        }

        public void ProcessAction(int x, int y, Func<int, int, int> action)
        {
            action(x, y);
            Console.WriteLine(action(x, y));
            Console.WriteLine("Func has been processed");
        }
    }
}
