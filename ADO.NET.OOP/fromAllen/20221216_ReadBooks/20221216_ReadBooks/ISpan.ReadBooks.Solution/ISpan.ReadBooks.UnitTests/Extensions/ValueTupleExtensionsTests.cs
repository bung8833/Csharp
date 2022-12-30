using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.ReadBooks.Extensions;

namespace ISpan.ReadBooks.UnitTests.Extensions
{
    internal class ValueTupleExtensionsTests
    {
        [Test]
        public void EnsureInOrder_順序正確_傳回原值() {
            (int, int) source = (4, 6);
            (int, int) expected = (4, 6);

            (int, int) actual = source.EnsureInOrder();

            Assert.AreEqual(expected, actual);

        }
        // html attribute屬性
        // property屬性

        [TestCase(14, 6)] // Attribute特徵項
        public void EnsureInOrder_順序相反_傳回對調後的值(   int begin, int end    )
        {
            (int, int) source = (begin, end);
            (int, int) expected = (6, 14);

            (int, int) actual = source.EnsureInOrder();

            Assert.AreEqual(expected, actual);

        }
    }
}
