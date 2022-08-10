using System;
using Xunit;
using Validators.Password;

namespace MyProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MyTest()
        {
            Assert.True(true, "Should be true");
        }
        
        [Fact]
    public void ValidPassword()
    {
      //Arrange
      var passwordValidator = new PasswordValidator();
      const string password = "Th1sIsapassword!";

      //Act
      bool isValid = passwordValidator.IsValid(password);

      //Assert
      Assert.True(isValid, $"The password {password} is not valid");
    }
    }
}
