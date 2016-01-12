using Mastermind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class ConsoleReader : IMastermindReader
    {

        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
