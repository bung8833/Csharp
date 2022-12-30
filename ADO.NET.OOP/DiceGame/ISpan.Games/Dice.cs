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
        public int Value { get; private set; } // 對外為ReadOnly

        public Dice(int value)
        {
            // 檢查數值
            if (value < 1 || value > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            
            Value = value;
        }

        public int CompareTo(Dice other)
        {
            if (other == null) return 1; //todo 亂加XD


            // this.Value 為 int, 而 int 有實作 IComparable, 一定有CompareTo這個Method
            return this.Value.CompareTo(other.Value);
            
            // 以下為垃圾
            //Dice x = this;
            //Dice y = other;

            //if (x.Value < y.Value)
            //{
            //    return -123;
            //}
            //else if (x.Value == y.Value)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 123;
            //}
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
