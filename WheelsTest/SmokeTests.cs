using System;
using Wheels;
using Xunit;
using FluentAssertions;

namespace WheelsTest
{
    public class SmokeTests
    {
        [Fact]
        public void ShouldAlwaysPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldPassIfDependenciesAreCorrect()
        {
            var program = new Startup();
            program.Should().NotBeNull();
        }
    }
}
