namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Calculator_Add_Method()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);

            Assert.Equal(5, result);
        }
    }
}