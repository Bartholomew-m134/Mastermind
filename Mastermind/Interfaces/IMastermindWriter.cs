using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Interfaces
{
    public interface IMastermindWriter
    {
        void WriteStartingPrompt();

        void WriteUserPrompt(int turnsLeft);

        void WriteLine(string output);

        void WriteGameOverMessage(bool answeredCorrectly);
    }
}
