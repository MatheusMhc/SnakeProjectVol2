using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjectVol2.Utils
{
    internal static class Util
    {
        public static bool isNull<T>(T obje) { return obje == null; }
        public static bool isNotNull<T>(T obj) { return !isNull(obj) ; }
    }
}
