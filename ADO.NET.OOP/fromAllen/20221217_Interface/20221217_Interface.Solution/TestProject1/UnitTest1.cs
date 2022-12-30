using ConsoleApp4;

namespace TestProject1
{
    public class LotteryTests
    {
        [Test]
        public void IsWinner_若是偶數就傳回true()
        {
            IRandomValueProvider provider = 
                new MockProvider_Even();
            var lottery = new Lottery(provider);
            
            bool actual = lottery.IsWinner();

            Assert.IsTrue(actual);// ???????
        }

        [Test]
        public void IsWinner_若是奇數就傳回false()
        {
            IRandomValueProvider provider =
                new MockProvider_Odd();
            var lottery = new Lottery(provider);

            bool actual = lottery.IsWinner();

            Assert.IsFalse(actual);// ???????
        }
    }
    public class MockProvider_Even : IRandomValueProvider
    {
        public int Next(int min, int max)
        {
            return 2;
        }
    }

    public class MockProvider_Odd : IRandomValueProvider
    {
        public int Next(int min, int max)
        {
            return 1;
        }
    }
}