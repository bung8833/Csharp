using ConsoleApp4;

namespace TestProject1
{
    public class LotteryTests
    {
        [Test]
        public void IsWinner_�Y�O���ƴN�Ǧ^true()
        {
            IRandomValueProvider provider = 
                new MockProvider_Even();
            var lottery = new Lottery(provider);
            
            bool actual = lottery.IsWinner();

            Assert.IsTrue(actual);// ???????
        }

        [Test]
        public void IsWinner_�Y�O�_�ƴN�Ǧ^false()
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