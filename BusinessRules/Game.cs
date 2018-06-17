using System;
using Adapters;
using BusinessRules.Properties;

namespace BusinessRules {
    public class Game : IGame {
        private readonly IMessenger _messenger;

        public Game(IMessenger messenger) {
            _messenger = messenger;
        }

        public bool IsOver { get; private set; }

        public int CorrectNumber { private get; set; } = GameService.GetRandomNumber();

        public void Check(int number) {
            switch (number.CompareTo(CorrectNumber)) {
                case 1:
                    _messenger.Deliver(Resources.TooHighMessage);
                    break;
                case -1:
                    _messenger.Deliver(Resources.TooLowMessage);
                    break;
                case 0:
                    _messenger.Deliver(Resources.CorrectMessage);
                    IsOver = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}