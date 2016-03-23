using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Extensions
    {
        public static IEnumerable<T> GetCompleteList<T,R>(this IEnumerable<R> collection, Func<R, IEnumerable<T>> selector)
        {
            List<T> res = new List<T>();

            collection.ToList().ForEach(x => res.AddRange(selector(x)));

            return res;
        }
    }
}
