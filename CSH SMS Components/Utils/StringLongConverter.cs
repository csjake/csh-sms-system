using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public class StringLongConverter
    {
        public static  long ConvertToLong(string input)
        {
            return input == null ? 0 : long.Parse(input);
        }

    }
}
