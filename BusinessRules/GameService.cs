using System;
using BusinessRules.Properties;

namespace BusinessRules {
    public static class GameService{
        public static int GetRandomNumber() {
            var random = new Random();
            var min = int.Parse(Resources.MinValue);
            var max = int.Parse(Resources.MaxValue);
            return random.Next(min, max);
        }
    }
}