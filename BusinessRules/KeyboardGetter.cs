using System;
using BusinessRules.Properties;

namespace BusinessRules {
    public class KeyboardGetter : INumberGetter {
        private static readonly string MessageForTheUser =
            string.Format(Resources.AskForANumber, Resources.MinValue, Resources.MaxValue);
        public int GetNumber() {
            bool parsedSuccessfully;
            int number;
            do {
                Console.WriteLine(MessageForTheUser);
                var input = Console.ReadLine();
                parsedSuccessfully = int.TryParse(input, out number);
            } while (!parsedSuccessfully);

            return number;
        }
    }
}