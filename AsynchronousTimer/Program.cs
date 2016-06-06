using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsynchronousTimer printLetter = new AsynchronousTimer(PrintLetterOnConsole, 5, 500);
            printLetter.Execute();

            AsynchronousTimer printNumber = new AsynchronousTimer(PrintNumberOnConsole, 3, 1000);
            printNumber.Execute();
        }

        private static void PrintLetterOnConsole(int i)
        {
            char letter = (char)('a' + i);
            Console.WriteLine(letter);
        }

        private static void PrintNumberOnConsole(int i)
        {
            Console.WriteLine(i + 1);
        }
    }
    }
}
