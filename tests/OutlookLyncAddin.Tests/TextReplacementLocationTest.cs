using System;
using OutlookLyncAddin.Common;
using Xunit;

namespace OutlookLyncAddin.Tests
{
    public class TextReplacementLocationTest
    {
        [Theory]
        [InlineData(1,10,5,4)]
        [InlineData(2,12,5,5)]
        [InlineData(3,5,4,4)]
        public void TestContainsPositive(int startLeft, int lengthLeft, int startRight, int lengthRight)
        {
            var left = new TextReplacementLocation(startLeft,lengthLeft,null);
            var right = new TextReplacementLocation(startRight, lengthRight, null);
            Assert.True(left.Contains(right));
        }

        [Theory]
        [InlineData(1, 10, 5, 7)]
        [InlineData(2, 12, 5, 11)]
        [InlineData(3, 5, 4, 5)]
        public void TestContainsNegative(int startLeft, int lengthLeft, int startRight, int lengthRight)
        {
            var left = new TextReplacementLocation(startLeft, lengthLeft, null);
            var right = new TextReplacementLocation(startRight, lengthRight, null);
            Assert.False(left.Contains(right));
        }

        [Theory]
        [InlineData(1,2)]
        [InlineData(2,2)]
        [InlineData(3,2)]
        [InlineData(4,1)]
        [InlineData(Int32.MinValue,Int32.MaxValue)]
        public void TestEqualsPositive(int start, int length)
        {
            var left = new TextReplacementLocation(start,length,null);
            var right = new TextReplacementLocation(start,length,"Some text");
            var asObject = (object)right;
            Assert.True(left.Equals(right));
            Assert.True(left == right);
            Assert.True(left.Equals(asObject));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(4, 1)]
        [InlineData(Int32.MinValue, Int32.MaxValue)]
        public void TestEqualsNegative(int start, int length)
        {
            var obj = (object)"Some text";
            var left = new TextReplacementLocation(start, length, null);
            var right = new TextReplacementLocation(start + 1, length, "Some text");
            var asObject = (object) right;
            Assert.False(left.Equals(right));
            Assert.False(left.Equals(null));
            Assert.False(left.Equals(obj));
            Assert.True(left != right);
            Assert.False(left.Equals(asObject));
        }
    }
}