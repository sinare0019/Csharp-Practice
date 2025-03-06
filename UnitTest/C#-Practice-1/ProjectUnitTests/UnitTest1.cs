using Xunit;
using C__Practice_1;

namespace ProjectUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int number1, number2, resultTest;
            number1 = 10;
            number2 = 20;
            int result = number1 + number2;
            var maths = new Maths();

            //Act
            resultTest = maths.Sum(number1, number2);

            //Asserts
            Assert.Equal(resultTest, result);
        }
    }
}