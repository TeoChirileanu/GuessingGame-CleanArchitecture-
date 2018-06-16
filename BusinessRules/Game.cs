using Adapters;
using BusinessRules.Properties;

namespace BusinessRules {
    public class Game : IGame {
        public IMessenger Messenger { private get; set; }

        public int CorrectNumber { get; set; }

        public void Check(int number) {
            if (number < CorrectNumber) {
                Messenger.Deliver(Resources.TooLowMessage);
                return;
            }

            if (number > CorrectNumber) {
                Messenger.Deliver(Resources.TooHighMessage);
                return;
            }

            Messenger.Deliver(Resources.CorrectMessage);
        }
    }
}