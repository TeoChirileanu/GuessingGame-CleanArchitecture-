using Adapters;
using BusinessRules.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessRules.Tests {
    [TestClass]
    public class GameTests {
        [TestMethod]
        public void GivenCorrectNumber50_WhenUserEnters25_MessageShouldBeTooLow() {
            // Arrange
            var mock = new Mock<IMessenger>();
            var game = new Game {CorrectNumber = 50, Messenger = mock.Object};
            // Act
            game.Check(25);
            // Assert
            mock.Verify(messenger => messenger.Deliver(Resources.TooLowMessage));
        }

        [TestMethod]
        public void GivenCorrectNumber25_WhenUserEnters50_MessageShouldBeTooHigh() {
            // Arrange
            var mock = new Mock<IMessenger>();
            var game = new Game {CorrectNumber = 25, Messenger = mock.Object};
            // Act
            game.Check(50);
            // Assert
            mock.Verify(messenger => messenger.Deliver(Resources.TooHighMessage));
        }

        [TestMethod]
        public void GivenCorrectNumber75_WhenUserEnters75_MessageShouldBeCorrect() {
            // Arrange
            var mock = new Mock<IMessenger>();
            var game = new Game {CorrectNumber = 75, Messenger = mock.Object};
            // Act
            game.Check(75);
            // Assert
            mock.Verify(messenger => messenger.Deliver(Resources.CorrectMessage));
        }
    }
}