using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public static class ListExtensions
    {
        public static IEnumerable<string?> GetItemsAsString<T>(this List<T> list)
        {
            foreach (var i in list.Select(t => t?.ToString()).ToList())
                yield return i;
        }

    }
}
