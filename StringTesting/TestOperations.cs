﻿using System;
using StringOperations;
using Xunit;

namespace StringTesting
{
    public class TestOperations
    {
        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        [Fact]
        public void Test_ConvertUpperLower()
        {
            // Arrange
            var test = "MeGhNa";
            var Expect = "mEgHnA";
            // Act
            var result = test.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        [Fact]
        public void Test1_ConvertUpperLower()
        {
            // Arrange
            var test = "aaBBccDD";
            var Expect = "AAbbCCdd";
            // Act
            var result = test.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        [Fact]
        public void Test2_ConvertUpperLower()
        {
            // Arrange
            var test = "@!#$%^&*()";
            var Expect = "@!#$%^&*()";
            // Act
            var result = test.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        [Fact]
        public void Test3_ConvertUpperLower()
        {
            // Arrange
            var test = "123456789";
            var Expect = "123456789";
            // Act
            var result = test.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        [Fact]
        public void Test4_ConvertUpperLower()
        {
            // Arrange
            var test = "        ";
            var Expect = "        ";
            // Act
            var result = test.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a copy of given input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        [Fact]
        public void Test5_ConvertUpperLower()
        {
            // Arrange
            var test = "";
            var Expect = "";
            // Act
            var result = test.ConvertUpperLower();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        /// </summary>
        [Fact]
        public void Test_CovertToTitleCase()
        {
            // Arrange
            var test = "the CLEVER fox";
            var Expect = "The CLEVER Fox";
            // Act
            var result = test.CovertToTitleCase();
            // Assert
            Assert.Equal(Expect, result);
        }

        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        /// </summary>
        [Fact]
        public void Test1_CovertToTitleCase()
        {
            // Arrange
            var test = "AAbc";
            var Expect = "AAbc";
            // Act
            var result = test.CovertToTitleCase();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        /// </summary>
        [Fact]
        public void Test2_CovertToTitleCase()
        {
            // Arrange
            var test = "<>?}{123";
            var Expect = "<>?}{123";
            // Act
            var result = test.CovertToTitleCase();
            // Assert
            Assert.NotEqual(Expect, result);
        }
        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        /// </summary>
        [Fact]
        public void Test3_CovertToTitleCase()
        {
            // Arrange
            var test = "ABCD!@3456{} xyz";
            var Expect = "ABCD!@3456{} Xyz";
            // Act
            var result = test.CovertToTitleCase();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
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
        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        [Fact]
        public void Test1_CheckLower()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "MEGHNA";
            // Act
            var result = expectedstring.CheckLower();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        [Fact]
        public void Test2_CheckLower()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "123456789";
            // Act
            var result = expectedstring.CheckLower();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        [Fact]
        public void Test3_CheckLower()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "!@#$%^&*()}{?";
            // Act
            var result = expectedstring.CheckLower();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        [Fact]
        public void Test4_CheckLower()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "              ";
            // Act
            var result = expectedstring.CheckLower();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Find if all the characters from given input string are in lower case or not
        /// </summary>
        [Fact]
        public void Test5_CheckLower()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "";
            // Act
            var result = expectedstring.CheckLower();
            // Assert
            Assert.True(result);
        }
        /// <summary>
        /// Return a capitalized version of given input string i.e. make the first character have upper case and the rest lower case.
        /// </summary>
        [Fact]
        public void Test_CovertToUpperCaseFirstCharater()
        {
            // Arrange
            var test = "meghna";
            var Expect = "Meghna";
            // Act
            var result = test.CovertToUpperCaseFirstCharater();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a capitalized version of given input string i.e. make the first character have upper case and the rest lower case.
        /// </summary>
        [Fact]
        public void Test1_CovertToUpperCaseFirstCharater()
        {
            // Arrange
            var test = "aaaBbbCCC";
            var Expect = "AaaBbbCCC";
            // Act
            var result = test.CovertToUpperCaseFirstCharater();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Return a capitalized version of given input string i.e. make the first character have upper case and the rest lower case.
        /// </summary>
        [Fact]
        public void Test2_CovertToUpperCaseFirstCharater()
        {
            // Arrange
            var test = "@Abcd";
            var Expect = "@Abcd";
            // Act
            var result = test.CovertToUpperCaseFirstCharater();
            // Assert
            Assert.NotEqual(Expect, result);
        }
        /// <summary>
        /// Find if all the characters from given input string are in upper case or not
        /// </summary>
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
        /// <summary>
        /// Find if all the characters from given input string are in upper case or not
        /// </summary>
        [Fact]
        public void Test1_CheckUpper()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "aaaaaaBBBBBBcccccDDDDD";
            // Act
            var result = expectedstring.CheckUpper();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Function to identify whether given input string can be converted to a valid numeric value or not.
        /// </summary>
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
        /// <summary>
        /// Function to identify whether given input string can be converted to a valid numeric value or not.
        /// </summary>
        [Fact]
        public void Test1_CheckNumeric()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "abCd";
            // Act
            var result = expectedstring.CheckNumeric();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Function to identify whether given input string can be converted to a valid numeric value or not.
        /// </summary>
        [Fact]
        public void Test2_CheckNumeric()
        {
            // Arrange
            //var stringOperation = new Operations();
            var expectedstring = "!@#$%^&";
            // Act
            var result = expectedstring.CheckNumeric();
            // Assert
            Assert.False(result);
        }
        /// <summary>
        /// Function to remove the last character from given the string
        /// </summary>
        [Fact]
        public void Test_RemoveLastCharater()
        {
            // Arrange
            var test = "Meghna";
            var Expect = "Meghn";
            // Act
            var result =test.RemoveLastCharater();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Function to remove the last character from given the string
        /// </summary>
        [Fact]
        public void Test1_RemoveLastCharater()
        {
            // Arrange
            var test = "TestingAssignment";
            var Expect = "TestingAssignmen";
            // Act
            var result = test.RemoveLastCharater();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Get the word count from an input string.
        /// </summary>
        [Fact]
        public void Test_WordCount()
        {
            // Arrange
            var test = "The quick brown fox jumps over the lazy dog";
            var Expect =9;
            // Act
            var result = test.WordCount();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Get the word count from an input string.
        /// </summary>
        [Fact]
        public void Test1_WordCount()
        {
            // Arrange
            var test = " Abcd EFGH iJKL mnOP QrST uVW XYZ ";
            var Expect = 9;
            // Act
            var result = test.WordCount();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Convert an input string to integer.
        /// </summary>
        [Fact]
        public void Test_ConvertStringToInt()
        {
            // Arrange
            var test = "12345";
            var Expect =12345;
            // Act
            var result = test.ConvertStringToInt();
            // Assert
            Assert.Equal(Expect, result);
        }
        /// <summary>
        /// Convert an input string to integer.
        /// </summary>
        [Fact]
        public void Test1_ConvertStringToInt()
        {
            // Arrange
            var test = "Abcd";
            var Expect = 0;
            // Act
            var result = test.ConvertStringToInt();
            // Assert
            Assert.Equal(Expect, result);
        }
    }
}
