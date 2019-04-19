using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public class StringLongConverter
    {
        public static long? ConvertToLong(string input)
        {
            long result;
            if (!long.TryParse(input, out result))
            {
                return null;
            };
            return result;            
        }

    }
}
