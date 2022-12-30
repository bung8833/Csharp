using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    internal class DefaultRandomValueProvider : IRandomValueProvider
    {
        public int Next(int min, int max)
        {
            return new Random(Guid.NewGuid().GetHashCode())
                       .Next(min, max);
        }
    }
}
