namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Calculator_Add_Method_1()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 5, 10)]
        public void Test_Calculator_Add_Method_2(int a, int b, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(a,b);

            Assert.Equal(expected, result);
        }
    }
}