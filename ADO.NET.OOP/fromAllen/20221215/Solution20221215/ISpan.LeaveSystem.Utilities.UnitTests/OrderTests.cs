namespace ISpan.LeaveSystem.Utilities.UnitTests
{
    public class OrderTests
    {
       
        [TestCase(100, 5)]
        [TestCase(119, 6)]
        public void CalcTax_¶Ç¦^5­wµ|ª÷(int price, int expected)
        {
            // arrange
            

            // action
            int actual = Order.CalcTax(price);

            // assert
            Assert.AreEqual(expected, actual);

        }
        
    }
}