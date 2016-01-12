using Mastermind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Mastermind
    {
        private const int CODE_LENGTH = 4;
        private const int LOWER_CODE_BOUND = 1;
        private const int UPPER_CODE_BOUND = 6;

        private IMastermindReader reader;
        private IMastermindWriter writer;
        private string secretCode;
        private int numberOfTries;

        public Mastermind(int numberOfTries)
        {
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
            this.numberOfTries = numberOfTries;
        }

        public void Play()
        {
            bool answeredCorrectly = false;

            GenerateNewCode();
            writer.WriteStartingPrompt();

            for (int i = 0; i < numberOfTries && !answeredCorrectly; i++)
            {
                string userInput = "";

                while (userInput.Length != CODE_LENGTH)
                {
                    writer.WriteUserPrompt(numberOfTries - i);
                    userInput = reader.ReadInput();
                }
                    
                writer.WriteLine(CompareCode(userInput));
                answeredCorrectly = secretCode.Equals(userInput);
            }

            writer.WriteGameOverMessage(answeredCorrectly);
        }

        private void GenerateNewCode()
        {
            Random random = new Random();
            StringBuilder newCode = new StringBuilder();

            for (int i = 0; i < CODE_LENGTH; i++)
            {
                newCode.Append(random.Next(LOWER_CODE_BOUND, UPPER_CODE_BOUND + 1));
            }

            secretCode = newCode.ToString();
        }

        private string CompareCode(string userInput)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder minusString = new StringBuilder();

            for (int i = 0; i < CODE_LENGTH; i++)
            {
                if(secretCode.ElementAt(i).Equals(userInput.ElementAt(i)))
                {
                    stringBuilder.Append("+");
                }
                else
                {
                    minusString.Append("-");
                }
            }

            return stringBuilder.Append(minusString).ToString();
        }
    }
}
