using Adapters;
using BusinessRules;

namespace ConsoleApp {
    internal class Program {
        private static void Main() {
            IGame game = new Game(new ConsoleMessenger());
            INumberGetter numberGetter = new KeyboardGetter();
            do {
                var guessedNumber = numberGetter.GetNumber();
                game.Check(guessedNumber);
            } while (!game.IsOver);
        }
    }
}