using Adapters;
using BusinessRules;

namespace ConsoleApp {
    internal class Program {
        private static void Main() {
            var controller = 
                new GameController(new Game(new ConsoleMessenger()), new KeyboardGetter());
            do {
                var guessedNumber = controller.GetNumber();
                controller.CheckNumber(guessedNumber);
            } while (!controller.IsGameOver());
        }
    }
}