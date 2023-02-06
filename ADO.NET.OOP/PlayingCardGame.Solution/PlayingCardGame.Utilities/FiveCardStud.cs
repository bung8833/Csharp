using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class FiveCardStud
    {
        private List<Card> _hand;

        public List<Card> Hand // 玩家的手牌 應介於0~5張
        {
            get
            {
                return _hand;
            }
            set
            {
                if (value.Count > 5)
                {
                    // todo 驗證Hand
                }
                _hand = value;
            }
        }

        public bool IsRoyalFlush(List<Card> hand)
        {
            // todo
            return false;
        }
    }
}
