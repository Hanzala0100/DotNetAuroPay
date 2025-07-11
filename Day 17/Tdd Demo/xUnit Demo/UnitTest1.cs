using Tdd_Demo;
using Xunit.Sdk;
namespace xUnit_Demo
{
    public class UnitTest1 :IClassFixture<CalculateFixture>
    {


        private readonly CalculateFixture _fixture;
        public UnitTest1(CalculateFixture fixture)
        {
            _fixture = fixture;
        }

        [Trait("Operation", "Addition")]

        [Fact(Timeout = 100)]
        public void CalculateFixture()
        {
            int num1 = 5, num2 = 10, actualResult, expectedResult = 15;
            Calculator calculator = _fixture.calculator;
            actualResult = calculator.add(num1, num2);
            Assert.Equal(expectedResult, actualResult);
        }



        [Trait("Operation", "Subtraction")]

        [Fact(Timeout=100)]
        public void TestToCheckSubtractMethod()
        {
            int num1 = 10, num2 = 5, actualResult, expectedResult = 5;
            Calculator calculator = new Calculator();
            actualResult = calculator.subtract(num1, num2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Operation", "Addition")]
        [Fact]
        public void TestToCheckAddMethod()
        {
            int num1 = 5, num2 = 10, actualResult, expectedResult = 15;
            Calculator calculator = new Calculator();
            actualResult = calculator.add(num1, num2);
            Assert.Equal(expectedResult, actualResult);

        }


        [Fact]

        [Trait("Operation", "Addition")]

        public void TestToCheckAddMethodWithNegativeNumbers()
        {
            int num1 = -5, num2 = -10, actualResult, expectedResult = -15;
            Calculator calculator = new Calculator();
            actualResult = calculator.add(num1, num2);
            Assert.Equal(expectedResult, actualResult);
        }
        [Trait("Operation", "Subtraction")]

        [Fact(Skip ="The test is skipped")]
       public void TestToCheckSubtractMethodWithNegativeNumbers()
        {
            int num1 = -10, num2 = -5, actualResult, expectedResult = -5;
            Calculator calculator = new Calculator();
            actualResult = calculator.subtract(num1, num2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Operation", "Subtraction")]

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 10, 10)]
        [InlineData(-30, 15, -45)]
        public void TestToCheckSubtractMethodWithMultipleData(int num1, int num2, int expectedResult)
        {
            Calculator calculator = new Calculator();
            int actualResult = calculator.subtract(num1, num2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Operation", "Division")]
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(-30, -3, 10)]
        [InlineData(0, 1, 0)]

        public void TestToCheckDivMethodWithMultipleData(int num1, int num2, int expectedResult)
        {
            Calculator calculator = new Calculator();
            int actualResult = calculator.div(num1, num2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Trait("Operation", "Division")]
        [Theory]
        [InlineData(10, 0)]
        [InlineData(20, 0)]
        public void TestToCheckDivMethodWithZero(int num1, int num2)
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.div(num1, num2));
        }

        [Trait("Operation", "PrintHiMessage")]
        [Theory]
        [InlineData("John", "Hi")]
        [InlineData("Jane", "Hi")]
        public void TestToCheckPrintHiMessageStartWithHi(string name, string expectedStart)
        {
            Calculator calculator = new Calculator();
            string actualResult = calculator.printHiMessage(name);
            Assert.StartsWith(expectedStart, actualResult);
        }


        [Trait("Operation", "PrintHiMessage")]
        [Theory]
        [InlineData("John", "John")]
        [InlineData("Jane", "Jane")]

        public void TestToCheckPrintHiMessageEndsWithName(string name, string expectedName)
        {
            Calculator calculator = new Calculator();
            string actualResult = calculator.printHiMessage(name);
            Assert.EndsWith(expectedName, actualResult);
        }

    }
}