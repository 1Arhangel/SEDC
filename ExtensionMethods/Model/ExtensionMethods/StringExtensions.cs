using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Length;
        }
    }
}
