using System.Collections.Generic;
using System.Linq;

namespace Monopoly.Tests
{
    public static class EnumerableExtensions
    {
        public static TSource Second<TSource>(this IEnumerable<TSource> collection)
        {
            return collection.Skip(1).Take(1).First();
        }
    }
}