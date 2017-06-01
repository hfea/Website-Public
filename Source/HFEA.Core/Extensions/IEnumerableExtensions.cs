using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Extensions
{
    public static class IEnumerableExtensions
    {
        public static PagedList<T> ToPagedList<T>(this IEnumerable<T> data, int page, int pageSize)
        {
            return new PagedList<T>(data, page, pageSize, true);
        }

        public static IEnumerable<T> FlattenBy<T>(this IEnumerable<T> e, Func<T, IEnumerable<T>> f)
        {
            return e.SelectMany(c => f(c).FlattenBy(f)).Concat(e);
        }

        public static IEnumerable<T> FlattenBy<T>(this IEnumerable<T> e, Func<T, IEnumerable<T>> f, bool checkNulls)
        {
            if (!checkNulls)
            {
                return e.FlattenBy(f);
            }
            else if (e == null)
            {
                return new List<T>();
            }

            return e.SelectMany(c => f(c).FlattenBy(f, checkNulls)).Concat(e);
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> data)
        {
            return data == null || data.Count() == 0;
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
        (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
