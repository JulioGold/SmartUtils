using System.Collections.Generic;
using System.Linq;

namespace SmartUtils
{
    public static class SmartUtils
    {
        public static bool CheckHasNull(params object[] values) => values.Any((obj) => obj == null);

        public static bool CheckHasNull<T>(IEnumerable<T> values) => values.Any((obj) => obj == null);
    }
}
