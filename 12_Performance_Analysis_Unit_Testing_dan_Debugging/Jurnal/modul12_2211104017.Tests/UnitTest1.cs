using modul12_2211104017;
using Xunit;

namespace modul12_2211104017.Tests
{
    public class CariNilaiPangkatTests
    {
        private readonly PangkatCalculator _calculator;

        public CariNilaiPangkatTests()
        {
            _calculator = new PangkatCalculator();
        }

        [Fact]
        public void Test_B_EqualToZero_ReturnsOne()
        {
            int result = _calculator.CariNilaiPangkat(0, 0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_B_Negative_ReturnsMinusOne()
        {
            int result = _calculator.CariNilaiPangkat(2, -3);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_A_GreaterThan100_Or_B_GreaterThan10_ReturnsMinusTwo()
        {
            int result1 = _calculator.CariNilaiPangkat(101, 5);
            int result2 = _calculator.CariNilaiPangkat(5, 11);

            Assert.Equal(-2, result1);
            Assert.Equal(-2, result2);
        }

        [Fact]
        public void Test_Overflow_ReturnsMinusThree()
        {
            int result = _calculator.CariNilaiPangkat(200, 5); // 200^5 melebihi batas int
            Assert.Equal(-3, result);
        }

        [Fact]
        public void Test_NormalPangkatCalculation()
        {
            int result = _calculator.CariNilaiPangkat(2, 3); // 2^3 = 8
            Assert.Equal(8, result);
        }
    }
}
