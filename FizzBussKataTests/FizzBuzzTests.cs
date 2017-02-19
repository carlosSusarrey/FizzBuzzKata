using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBussKata;
using FluentAssertions;
using Xunit;

namespace FizzBussKataTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void Every_multiple_of_three_prints_Fizz_instead_of_the_number(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(20)]
        public void Every_multiple_of_fice_prints_Buzz_instead_of_the_number(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be("Buzz");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        public void Non_multiples_of_five_or_three_prints_the_number(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be(number.ToString());
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void Every_multiple_of_five_and_three_prints_FizzBuzz_instead_of_the_number(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be("FizzBuzz");
        }
    }
}
