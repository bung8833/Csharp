using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.ReadBooks.Extensions;

namespace ISpan.ReadBooks.UnitTests.Extensions
{
    internal class IntExtensionsTests
    {
        [Test]
        public void EnsureInRange_介於min_max之間_傳回原值()
        {
            int min = 0, max = 10;
            int pageIndex = 5;

            int actual = pageIndex.EnsureInRange(min, max);

            Assert.AreEqual(pageIndex, actual);

        }

        [Test]
        public void EnsureInRange_小於min_傳回min()
        {
            int min = 0, max = 10;
            int pageIndex = -1;

            int actual = pageIndex.EnsureInRange(min, max);

            Assert.AreEqual(min, actual);

        }

        [Test]
        public void EnsureInRange_大於max_傳回max()
        {
            int min = 0, max = 10;
            int pageIndex = 11;

            int actual = pageIndex.EnsureInRange(min, max);

            Assert.AreEqual(max, actual);

        }
    }
}
