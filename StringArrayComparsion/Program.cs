using System;
using System.Collections.Generic;

namespace StringArrayComparsion
{
    class Program
    {
        public static IStringArrayComparer StringArrayComparer = new StringArrayComparer();

        public static void Main()
        {
            var array1 = new[] { "a", "b", "c", "de", "g" };
            var array2 = new[] { "a", "bc", "d", "eg" };

            StringArrayComparer.Initialize(array1, array2);
            var result = StringArrayComparer.AreArraysEqual();

            Console.WriteLine(result);
        }
    }
}
