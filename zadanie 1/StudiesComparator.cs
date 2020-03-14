using System;
using System.Collections.Generic;

namespace zadanie_1
{
    public class StudiesComparator : IEqualityComparer<Studies>
    {
        public bool Equals(Studies x, Studies y)
        {
            return StringComparer
                .InvariantCultureIgnoreCase
                .Equals(x.Major, y.Major);
        }

        public int GetHashCode(Studies obj)
        {
            return StringComparer
                .CurrentCultureIgnoreCase
                .GetHashCode(obj.Major);
        }
    }
}