using BusinessRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;

namespace WebApiMessenger.Tests {
    [TestClass]
    public class MessagesControllerTests {
        [TestMethod]
        public void Foo() {
            // i wanna check if the game still works with this custom implementation
            // Arrange
            var messenger = new WebMessengerController();
            var game = new Game {
                CorrectNumber = 50,
                Messenger = messenger
            };
            // Act
            game.Check(50);
            //ps: i don't know how to integrate and test these components
            // Assert
            //Assert.IsTrue(messenger.DeliverOverWeb());
            // assert that deliveroverweb has been called with appropriate parameter
        }
    }
}