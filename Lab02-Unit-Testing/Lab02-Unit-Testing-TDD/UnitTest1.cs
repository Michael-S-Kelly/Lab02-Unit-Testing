using System;
using Xunit;
using static Lab02_Unit_Testing.Program;

namespace Lab02_Unit_Testing_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanRegisterWithdrawTwenty()
        {
            double input = 20;
            Assert.Equal(20, RemoveFunds(input));
        }

        /*
        [Theory]
        [InlineData(10)]
        public void WithdrawSeries(double amount)
        {
            Assert.Equal(amount, RemoveFunds(amount));
        }
        */
    }
}
