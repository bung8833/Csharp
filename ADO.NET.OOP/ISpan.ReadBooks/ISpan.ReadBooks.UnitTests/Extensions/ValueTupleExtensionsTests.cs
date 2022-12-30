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
        public void EnsureInOrser_正常順序_傳回原tuple()
        {
            (int, int) source = (0, 1);
            (int, int) expected = (0, 1);

            (int, int) actual = source.EnsureInOrder();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EnsureInOrser_順序顛倒_傳回正常順序()
        {
            (int, int) source = (1, 0);
            (int, int) expected = (0, 1);

            (int, int) actual = source.EnsureInOrder();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EnsureInOrser_不分順序_傳回原值()
        {
            (int, int) source = (0, 0);
            (int, int) expected = (0, 0);

            (int, int) actual = source.EnsureInOrder();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(14, 6)]
        public void EnsureInOrser(int first, int last)
        {
            (int, int) source = (first, last);
            (int, int) expected = (6, 14);

            (int, int) actual = source.EnsureInOrder();
            Assert.AreEqual(expected, actual);
        }
    }
}
