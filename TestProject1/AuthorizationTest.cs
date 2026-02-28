using hw12_exception;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestProject1.MockImitation;


namespace TestProject1
{
    [TestClass]
    public class AuthorizationTest
    {
        [TestMethod]
        public void ValidateAuthorization_Successful()
        {
            MyAuthorization.ValidateAuthorization("Login1", "Pass1", "Pass1");
        }

        [TestMethod]
        public void ValidateAuth_LoginHasSpace_ThrowsLoginException()
        {
            var ex = Assert.ThrowsException<WrongLoginException>(() =>
            {
                MyAuthorization.ValidateAuthorization("Login 1", "Pass1", "Pass1");
            });

            Assert.IsTrue(ex.Message.Contains("Incorrect login."));
        }

        [TestMethod]
        public void ValidateAuth_PassWithoutNumber_ThrowsPassException()
        {
            var ex = Assert.ThrowsException<WrongPasswordException>(() =>
            {
                MyAuthorization.ValidateAuthorization("Login1", "Pass", "Pass");
            });

            Assert.IsTrue(ex.Message.Contains("Incorrect password."));
        }


        [TestMethod]
        public void TestMockUnderstanding()
        {
            var mockService = new Mock<ICreateLogin>();
            mockService.Setup(s => s.SendLogin()).Returns("TestProject1");

            var manager = new LoginManager(mockService.Object);

            var result = manager.PrintLogin();

            Assert.AreEqual("Result: TestProject1", result);
        }
    }
}
