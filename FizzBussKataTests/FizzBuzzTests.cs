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
        [Fact]
        public void Every_multiple_of_three_prints_Fizz_instead_of_the_number()
        {
            FizzBuzz.ResultOf(3).Should().Be("Fizz");
        }
    }
}
