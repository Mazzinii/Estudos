namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact(DisplayName = "Given valid numbers, when sum then should success ")]
        //Given_When_Then
        public void GivenValidNumbers_WhenSum_ThenShoulSuccess()
        {
            //arrange
            const int resultExpect = 5;
            const int firstNumber = 3;
            const int secondNumber = 2;

            //act
            var resultActual = Calculator.Sum(firstNumber, secondNumber);

            //assert
            Assert.Equal(resultExpect, resultActual);

        }
    }
}
