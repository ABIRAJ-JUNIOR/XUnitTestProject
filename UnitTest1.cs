namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact (Skip = "not implementation")]
        public void Test_Add()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 3, 7)]
        [InlineData(10, 10, 9)]
        public void Test_Add_Multiple(int x, int y, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(x, y);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> DiscountTestData =>
        new List<object[]>
        {
                new object[] { 100m, 0m, 100m },
                new object[] { 100m, 25m, 75m },
                new object[] { 100m, 100m, 0m }
        };

        [Theory]
        [MemberData(nameof(DiscountTestData))]
        public void ApplyDiscount_ValidInputs_ReturnsExpected(decimal price, decimal discount, decimal expected)
        {
            var service = new DiscountService();
            var result = service.ApplyDiscount(price, discount);
            Assert.Equal(expected, result);
        }
    }
}