using System;
using StringOperations;
using Xunit;

namespace StringTesting
{
    public class TestOperations
    {
        [Fact]
        public void Test_ConvertUpperLower()
        {
            // Arrange
            var x = "MeGhNa";
            var Expect = "mEgHnA";

            // Act
            var result = Operations.ConvertUpperLower(x);
            // Assert
            Assert.Equal(Expect, result);
        }
    }
}
