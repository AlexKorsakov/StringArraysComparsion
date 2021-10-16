using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayComparsion
{
    public class StringArrayComparer : IStringArrayComparer
    {
        private string[] _left;
        private string[] _right;

        public void Initialize(string[] left, string[] right)
        {
            _left = left ?? throw new ArgumentNullException(nameof(left));
            _right = right ?? throw new ArgumentNullException(nameof(right));
        }

        public bool AreArraysEqual()
        {
            var leftSymbols = GetAllSymbols(_left);
            var rightSymbols = GetAllSymbols(_right);

            if (leftSymbols.Count() != rightSymbols.Count()) return false;

            using var leftEnumerator = leftSymbols.GetEnumerator();
            using var rightEnumerator = rightSymbols.GetEnumerator();

            while (leftEnumerator.MoveNext() && rightEnumerator.MoveNext())
            {
                Console.WriteLine(leftEnumerator.Current + " | " + rightEnumerator.Current);

                if (leftEnumerator.Current != rightEnumerator.Current) return false;
            }
            return true;
        }


        private IEnumerable<char> GetAllSymbols(string[] array)
        {
            foreach (var item in array)
            {
                foreach (var symbol in item)
                {
                    yield return symbol;
                }
            }
        }
    }
}
