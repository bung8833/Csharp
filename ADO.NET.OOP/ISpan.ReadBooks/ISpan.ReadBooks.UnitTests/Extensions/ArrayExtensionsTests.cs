using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.ReadBooks.Extensions;

namespace ISpan.ReadBooks.UnitTests.Extensions
{
    internal class ArrayExtensionsTests
    {
        private string[] paragraphs = null;

        [SetUp]
        public void Setup()
        {
            paragraphs = Enumerable.Range(0, 10).Select(x => x.ToString()).ToArray();
        }

        [Test]
        public void GetSubArray_null_Returns空陣列()
        {
            string[] expected = Array.Empty<string>();
            string[] source = null;

            ShouldBeCollectionEqual(source, expected);
        }

        [Test]
        public void GetSubArray_空陣列_Returns空陣列()
        {
            string[] expected = Array.Empty<string>();
            string[] source = new string[0];

            ShouldBeCollectionEqual(source, expected);
        }

        [TestCase(1, 3, "1,2,3")]
        public void GetSubArray_Returns範圍內的子陣列(int beginIndex, int endIndex, string expectedValue)
        {
            string[] expected = expectedValue.Split(',');
            string[] source = this.paragraphs;

            ShouldBeCollectionEqual(source, expected, beginIndex, endIndex);
        }

        [Test]
        public void GetSubArray_beginIndex小於零_視為0()
        {
            string[] expected = new string[] { "0", "1", "2" };
            int beginIndex = -1, endIndex = 2;
            string[] source = this.paragraphs;

            ShouldBeCollectionEqual(source, expected, beginIndex, endIndex);
        }

        [Test]
        public void GetSubArray_beginIndex大於陣列邊界_視為最後一項值()
        {
            string[] expected = new string[] { "9" };
            string[] source = this.paragraphs;
            int beginIndex = source.Length, endIndex = source.Length - 1;

            ShouldBeCollectionEqual(source, expected, beginIndex, endIndex);
        }

        [TestCase(3, 1, "1,2,3")]
        public void GetSubArray_範圍值大小相反_自動對調(int beginIndex, int endIndex, string expectedValue)
        {
            string[] expected = expectedValue.Split(',');
            string[] source = this.paragraphs;

            ShouldBeCollectionEqual(source, expected, beginIndex, endIndex);
        }


        private void ShouldBeCollectionEqual(string[] source, string[] expected, int beginIndex = 0, int endIndex = 9)
        {

            string[] actual = source.GetSubArray(beginIndex, endIndex);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
