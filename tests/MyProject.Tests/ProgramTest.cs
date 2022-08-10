using System;
using Xunit;


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
  public void ValidEmail()
  {
      //Arrange
    var mailManager = new MailManager();
    const string mailAddress = "john.smith@company.com";
 
      //Act
      bool isValid = mailManager.IsValidAddress(mailAddress);
 
      //Assert
    Assert.True(isValid, $"The email {mailAddress} is not valid");
  }
        
        
    }
}
