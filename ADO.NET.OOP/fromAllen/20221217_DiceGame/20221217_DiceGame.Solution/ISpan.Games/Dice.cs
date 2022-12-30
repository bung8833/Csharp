using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    /// <summary>
    /// 單顆骰子的資訊
    /// </summary>
    public class Dice : IComparable<Dice>
    {
        public int Value { get; private set; }
        public Dice(int value)
        {
            // pre conditions
            if (value < 1 || value > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
                //throw new ArgumentOutOfRangeException("value");
            }

            Value = value;
        }

        public int CompareTo(Dice other)
        {
            return this.Value.CompareTo(other.Value);

        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
