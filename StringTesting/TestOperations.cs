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
        [Fact]
        public void Test_CovertToTitleCase()
        {
            // Arrange
            var x = "the CLEVER fox";
            var Expect = "The CLEVER Fox";

            // Act
            var result = Operations.CovertToTitleCase(x);
            // Assert
            Assert.Equal(Expect, result);
        }
        [Fact]
        public void Test_CheckLower()
        {
            // Arrange
            var stringOperation = new Operations();
            var expectedstring = "meghna";

            // Act
            var result = stringOperation.CheckLower(expectedstring);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Test_CovertToUpperCaseFirstCharater()
        {
            // Arrange
            var x = "meghna";
            var Expect = "Meghna";

            // Act
            var result = Operations.CovertToUpperCaseFirstCharater(x);
            // Assert
            Assert.Equal(Expect, result);
        }
        [Fact]
        public void Test_CheckUpper()
        {
            // Arrange
            var stringOperation = new Operations();
            var expectedstring = "MEGHNA";

            // Act
            var result = stringOperation.CheckUpper(expectedstring);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Test_CheckNumeric()
        {
            // Arrange
            var stringOperation = new Operations();
            var expectedstring = "12345";

            // Act
            var result = stringOperation.CheckNumeric(expectedstring);

            // Assert
            Assert.True(result);
        }
    }
}
