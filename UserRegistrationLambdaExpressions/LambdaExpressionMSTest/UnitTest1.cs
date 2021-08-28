using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationLambdaExpressions;

namespace LambdaExpressionMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validatingFirstName_ShouldReturnTrue()
        {
            string FirstName = "Suchindra";
            bool result = LambdaFunction.isFirstNameValidornot(FirstName, regex.firstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void validatingLastName_ShouldReturnTrue()
        {
            string LastName = "Sharma";
            bool result = LambdaFunction.IsLastNameValidornot(LastName, regex.lastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void validatingEmail_ShouldReturnTrue()
        {
            string EmailId = "abc.xyz@gmail.com";
            bool result = LambdaFunction.IsEmailIdValidornot(EmailId, regex.emailId);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatingPhoneNo_ShouldReturnTrue()
        {
            string phoneNo = "91 9876543210";
            bool result = LambdaFunction.IsPhoneNoValidornot(phoneNo, regex.phoneNumber);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void validatingPassword_ShouldReturnTrue()
        {
            string Password = "abcdefG@12";
            bool result = LambdaFunction.isPasswordValidornot(Password, regex.password);
            Assert.IsTrue(result);
        }

    }
}

