using StringArrayComparsion;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class StringArrayComparerShould
    {
        [TestCase(new[] { "" }, new[] { "" })]
        [TestCase(new[] { "a" }, new[] { "a" })]
        [TestCase(new[] { "abcde" }, new[] { "a", "b", "cde" })]
        [TestCase(new[] { "ab", "cd" }, new[] { "abcd" })]
        public void AreArraysEqual(string[] left, string[] right)
        {
            var stringArrayComparer = new StringArrayComparer();
            stringArrayComparer.Initialize(left, right);

            var result =  stringArrayComparer.AreArraysEqual();

            Assert.IsTrue(result);
        }

        [TestCase(new[] { "a" }, new[] { "ab" })]
        [TestCase(new[] { "abcde" }, new[] { "a", "b", "cdef" })]
        [TestCase(new[] { "ab", "cd" }, new[] { "abcde" })]
        public void AreArraysNotEqual(string[] left, string[] right)
        {
            var stringArrayComparer = new StringArrayComparer();
            stringArrayComparer.Initialize(left, right);

            var result = stringArrayComparer.AreArraysEqual();

            Assert.IsFalse(result);
        }
    }
}
