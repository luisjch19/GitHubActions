using System;
using Xunit;


namespace MyProject.Tests
{
    public class UnitTest1
    {
        public static double Add(double number1, double number2)  
        {             
            return (number1 + number2);  
        }  
  
        public static double Subtract(double number1, double number2)  
        {  
            return (number1 - number2);  
        }  
  
        public static double Multiply(double number1, double number2)  
        {  
            return (number1 * number2);  
        }  
  
        public static double Divide(double number1, double number2)  
        {  
            return (number1 / number2);  
        }  
        [Fact]
        public void MyTest()
        {
            Assert.True(true, "Should be true");
        }
        
        [Fact]  
        public void Task_Add_TwoNumber()  
        {  
            // Arrange  
            var num1 = 2.9;  
            var num2 = 3.1;  
            var expectedValue = 6;  
  
            // Act  
            var sum = Add(num1, num2);  
  
            //Assert  
            Assert.Equal(expectedValue, sum, 1);  
        }  
  
        [Fact]  
        public void Task_Subtract_TwoNumber()  
        {  
            // Arrange  
            var num1 = 2.9;  
            var num2 = 3.1;  
            var expectedValue = -0.2;  
  
            // Act  
            var sub = Subtract(num1, num2);  
  
            //Assert  
            Assert.Equal(expectedValue, sub, 1);  
        }  
  
        [Fact]  
        public void Task_Multiply_TwoNumber()  
        {  
            // Arrange  
            var num1 = 2.9;  
            var num2 = 3.1;  
            var expectedValue = 8.99;  
  
            // Act  
            var mult = Multiply(num1, num2);  
  
            //Assert  
            Assert.Equal(expectedValue, mult, 2);  
        }  
  
        [Fact]  
        public void Task_Divide_TwoNumber()  
        {  
            // Arrange  
            var num1 = 2.9;  
            var num2 = 3.1;  
            var expectedValue = 0.94; //Rounded value  
  
            // Act  
            var div = Divide(num1, num2);  
  
            //Assert  
            Assert.Equal(expectedValue, div, 2);  
        }  
        
        
    }
}
