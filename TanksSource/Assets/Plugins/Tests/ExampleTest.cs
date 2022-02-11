using FluentAssertions;
using NUnit.Framework;
using TanksGB.General;

namespace Tests
{
    public class ExampleTest
    {
        [Test]
        public void WhenMultiply2_And2_ThenReturns4()
        {
            // Arrange.
            var calculator = new Calculator();
            // Act.
            int result = calculator.Multiply(2, 2);
            // Assert.
            result.Should().Be(4);
        }

    }
}
