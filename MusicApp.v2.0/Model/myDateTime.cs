using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class myDateTime
    {
        public static int ReleaseYear(this DateTime param)
        {
            return param.Year;
        }
    }
}
