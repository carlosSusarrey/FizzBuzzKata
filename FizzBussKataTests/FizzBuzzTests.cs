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

        [Theory]
        [InlineData(23)]
        [InlineData(3)]
        [InlineData(13)]
        [InlineData(31)]
        public void A_number_is_a_Fizz_if_the_number_contains_a_number_three(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(52)]
        [InlineData(58)]
        public void A_number_is_a_Buzz_if_the_number_contains_a_number_three(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be("Buzz");
        }

        [Theory]
        [InlineData(51)]
        [InlineData(57)]
        [InlineData(54)]
        public void A_number_is_a_FizzBuzz_if_it_contains_both_3_and_5(int number)
        {
            FizzBuzz.ResultOf(number).Should().Be("FizzBuzz");
        }
    }
}
