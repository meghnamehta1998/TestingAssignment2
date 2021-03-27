using System;
using StringOperations;
using Xunit;

namespace StringTesting
{
    public class TestOperations
    {
        //Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        [Fact]
        public void Test_ConvertUpperLower()
        {
            // Arrange
            var x = "MeGhNa";
            var Expect = "mEgHnA";
            // Act
            var result = x.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        //Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        [Fact]
        public void Test_CovertToTitleCase()
        {
            // Arrange
            var x = "the CLEVER fox";
            var Expect = "The CLEVER Fox";
            // Act
            var result = x.CovertToTitleCase();
            // Assert
            Assert.Equal(Expect, result);
        }
        //Find if all the characters from given input string are in lower case or not
        [Fact]
        public void Test_CheckLower()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "meghna";
            // Act
            var result =expectedstring.CheckLower();
            // Assert
            Assert.True(result);
        }
        //Return a capitalized version of given input string i.e. make the first character have upper case and the rest lower case.
        [Fact]
        public void Test_CovertToUpperCaseFirstCharater()
        {
            // Arrange
            var x = "meghna";
            var Expect = "Meghna";
            // Act
            var result = x.CovertToUpperCaseFirstCharater();
            // Assert
            Assert.Equal(Expect, result);
        }
        //Find if all the characters from given input string are in upper case or not
        [Fact]
        public void Test_CheckUpper()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "MEGHNA";
            // Act
            var result = expectedstring.CheckUpper();
            // Assert
            Assert.True(result);
        }
        //Function to identify whether given input string can be converted to a valid numeric value or not.
        [Fact]
        public void Test_CheckNumeric()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "12345";
            // Act
            var result = expectedstring.CheckNumeric();
            // Assert
            Assert.True(result);
        }
        //Function to remove the last character from given the string
        [Fact]
        public void Test_RemoveLastCharater()
        {
            // Arrange
            var x = "Meghna";
            var Expect = "Meghn";
            // Act
            var result =x.RemoveLastCharater();
            // Assert
            Assert.Equal(Expect, result);
        }
        //Get the word count from an input string.
        [Fact]
        public void Test_WordCount()
        {
            // Arrange
            var x = "The quick brown fox jumps over the lazy dog";
            var Expect =9;
            // Act
            var result = x.WordCount();
            // Assert
            Assert.Equal(Expect, result);
        }
        //Convert an input string to integer.
        [Fact]
        public void Test_ConvertStringToInt()
        {
            // Arrange
            var x = "12345";
            var Expect =12345;
            // Act
            var result = x.ConvertStringToInt();
            // Assert
            Assert.Equal(Expect, result);
        }
    }
}
