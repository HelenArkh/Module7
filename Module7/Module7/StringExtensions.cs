using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    static class StringExtensions
    {
        public static char GetLastChar(this string source)
        {
            return source[source.Length - 1];
        }

        public static bool Contains(this string value)
        {
            Console.WriteLine("Вызван метод расширения");

            return true;
        }
    }
}
