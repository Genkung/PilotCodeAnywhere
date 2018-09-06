using System;
using Xunit;
using GenWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GenUnitTest
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,1,1)]
        [InlineData(1,0,1)]
        [InlineData(6,7,13)]
        [InlineData(-6,0,-6)]
        [InlineData(-6,7,1)]
        [InlineData(6,-7,-1)]
        [InlineData(0.6,-7,-6.4)]
        [InlineData(-6.3,-7.4,-13.7)]
        public void Plus(double valueFirst, double valueSecond, double result)
        {
            var cal = new CalculatorController();
            Assert.Equal(result,cal.Plus(valueFirst,valueSecond));
        }
        [Fact]
        public void Minus()
        {
            Assert.True(true);
        }
        [Fact]
        public void Multiple()
        {
            Assert.True(true);
        }
        [Fact]
        public void Divine()
        {
            Assert.True(true);
        }
    }
}
