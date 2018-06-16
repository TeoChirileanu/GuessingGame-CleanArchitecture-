using System;

namespace Adapters {
    public class ConsoleMessenger : IMessenger {
        public void Deliver(string message) {
            Console.WriteLine(message);
        }
    }
}