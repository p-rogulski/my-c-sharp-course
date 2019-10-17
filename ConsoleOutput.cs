using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    class ConsoleOutput:IOutput
    {
        public void PrintResult(string result)
        {
            Console.WriteLine(result);
        }


    }
}
