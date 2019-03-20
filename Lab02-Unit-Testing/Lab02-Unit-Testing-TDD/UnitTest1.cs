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
            double amount = 20;
            Assert.Equal(20, RemoveFunds(amount));
        }

        [Fact]
        public void CanRegisterWithdrawForty()
        {
            double amount = 40;
            Assert.Equal(40, RemoveFunds(amount));
        }

        
        [Fact]
        public void CanRegisterWithdrawOneThousandTwenty()
        {
            double input = 1020;
            Assert.Equal(0, RemoveFunds(input));
        }

        [Fact]
        public void CanRegisterWithdrawNegitiveAmount()
        {
            double amount = -40;
            Assert.Equal(0, RemoveFunds(amount));
        }

        [Fact]
        public void CanRegisterDepositTwenty()
        {
            double amount = 20;
            Assert.Equal(20, AddFunds(amount));
        }

        [Fact]
        public void CanRegisterDepositNegative()
        {
            double amount = -20;
            Assert.Equal(0, AddFunds(amount));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        [InlineData(70)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(100)]
        [InlineData(200)]

        public void WithdrawSeries(double amount)
        {
            Assert.Equal(amount, RemoveFunds(amount));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        [InlineData(70)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(100)]
        [InlineData(200)]

        public void DepositSeries(double amount)
        {
            Assert.Equal(amount, AddFunds(amount));
        }

    }
}
