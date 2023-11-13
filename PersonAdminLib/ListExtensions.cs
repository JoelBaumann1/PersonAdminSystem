using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public static class ListExtensions
    {
        public static List<string?> GetItemsAsString<T>(this List<T> list)
        {
            return list.Select(t => t?.ToString()).ToList();
        }

    }
}
