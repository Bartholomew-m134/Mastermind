using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Program
    {
        private const int NUM_OF_TRIES = 6;

        public static void Main(string[] args)
        {
            Mastermind mastermind = new Mastermind(NUM_OF_TRIES);

            while (true)
            {
                mastermind.Play();
            }
        }
    }
}
