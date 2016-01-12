using Mastermind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class ConsoleWriter : IMastermindWriter
    {
        public void WriteStartingPrompt()
        {
            Console.WriteLine("Welcome to Mastermind!");
        }

        public void WriteUserPrompt(int turnsLeft)
        {
            Console.WriteLine("You have " + turnsLeft + " turn(s) left. Please enter your guess:");
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        public void WriteGameOverMessage(bool answeredCorrectly)
        {
            if (answeredCorrectly)
            {
                Console.WriteLine("You solved it!\n");
            }
            else
            {
                Console.WriteLine("You lose :(\n");
            }
        }
    }
}
