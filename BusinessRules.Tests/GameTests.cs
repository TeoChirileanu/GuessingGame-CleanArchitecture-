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
            var messengerMock = new Mock<IMessenger>();
            var game = new Game(messengerMock.Object) {CorrectNumber = 50};
            // Act
            game.Check(25);
            // Assert
            messengerMock.Verify(messenger => messenger.Deliver(Resources.TooLowMessage));
        }

        [TestMethod]
        public void GivenCorrectNumber25_WhenUserEnters50_MessageShouldBeTooHigh() {
            // Arrange
            var messengerMock = new Mock<IMessenger>();
            var game = new Game(messengerMock.Object) { CorrectNumber = 25 };
            // Act
            game.Check(50);
            // Assert
            messengerMock.Verify(messenger => messenger.Deliver(Resources.TooHighMessage));
        }

        [TestMethod]
        public void GivenCorrectNumber75_WhenUserEnters75_MessageShouldBeCorrect() {
            // Arrange
            var messengerMock = new Mock<IMessenger>();
            var game = new Game(messengerMock.Object) { CorrectNumber = 75 };
            // Act
            game.Check(75);
            // Assert
            messengerMock.Verify(messenger => messenger.Deliver(Resources.CorrectMessage));
        }
    }
}