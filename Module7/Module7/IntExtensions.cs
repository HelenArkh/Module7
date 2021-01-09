using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    static class IntExtensions
    {
        public static int GetNegative(this int source)
        {
            if (source > 0)
            {
                return -source;
            }
            else
            {
                return source;
            }
        }

        public static int GetPositive(this int source)
        {
            if (source < 0)
            {
                return - source;
            }
            else
            {
                return source;
            }
        }
    }
}
