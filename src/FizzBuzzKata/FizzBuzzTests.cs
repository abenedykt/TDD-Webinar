using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzGame _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzzGame();
        }

        [Fact]
        public void When_I_play_1_should_return_1()
        {
            var result = _sut.Play(1);
            result.Should().Be("1");
        }

        [Fact]
        public void When_I_play_3_should_return_Fizz()
        {
            var result = _sut.Play(3);
            result.Should().Be("Fizz");
        }

        [Fact]
        public void When_I_play_5_should_return_Buzz()
        {
            var result = _sut.Play(5);
            result.Should().Be("Buzz");
        }

        [Fact]
        public void When_I_play_15_should_return_Fizz_Buzz()
        {
            var result = _sut.Play(15);
            result.Should().Be("Fizz Buzz");
        }
    }
}
