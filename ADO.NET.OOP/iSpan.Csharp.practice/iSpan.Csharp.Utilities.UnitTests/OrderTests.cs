namespace iSpan.Csharp.Utilities.UnitTests
{
    public class Tests
    {
        
        [TestCase(100,  5)]
        [TestCase(119,  6)]
        [TestCase(  0,  0)]
        [TestCase(210, 11)]
        [TestCase(-119, -6)]
        [TestCase(99999, 5000)]
        public void ClacTax_�Ǧ^5�w�|��(int Price, int expected)
        {
            // arrange

            //int Price = 100;
            //int expected = 5;


            // action

            int actual = Order.ClacTax(Price);


            // assert

            Assert.AreEqual(expected, actual);
        }


        //[Test]
        //public void ClacTax_����119()
        //{
        //    // arrange
        //    int Price = 119;
        //    int expected = 6;


        //    // action
        //    int actual = Order.ClacTax(Price);

        //    // assert

        //    Assert.AreEqual(expected, actual);
        //}
    }
}