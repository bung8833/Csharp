using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AllenHw_GachaMachine_dll
{
    // 題目 商品售價50

    public class BusinessRule
    {

        // 功能 判斷狀態 使否允許{出貨、退幣}
        // 功能 投幣 -> 更新機器餘額->判斷/更新機器狀態->顯示狀態
        // 功能 出貨 -> 更新機器餘額->判斷/更新機器狀態->顯示狀態
        // 功能 退幣 -> 更新機器餘額->判斷/更新機器狀態->顯示狀態
        public void  UpdateMachineMoney (int money) {
            Machine.CustomerMoney = money;

        }
        public State JudgeState(int userProdPrice) {
            // 判斷/更新機器狀態
            if (Machine.CustomerMoney == 0)
            {
                Machine.MachineState = State.Waiting;
                return State.Waiting;
            }
            else if (Machine.CustomerMoney < userProdPrice)
            {
                Machine.MachineState = State.Refundable;
                return State.Refundable;
            } else if (Machine.CustomerMoney >= userProdPrice) {
                Machine.MachineState = State.Refundable_CanBeShipped;
                return State.Refundable_CanBeShipped;
            }
            return State.Waiting;
        }

        public int InsertMoney(int insertMoney)
        {
            // 功能 投幣 -> 更新機器餘額->判斷/更新機器狀態
            //回傳剩餘金額
            Machine.CustomerMoney += insertMoney;

            JudgeState(new Product().Price);
            return Machine.CustomerMoney;

        }
        public int RefundMoney() {
            // 功能 退幣 -> 更新機器餘額->判斷/更新機器狀態
            int refundMoney = Machine.CustomerMoney;
            Machine.CustomerMoney = 0;

            JudgeState(new Product().Price);
            return refundMoney;
        }
        public int ShipMoney(int productPrice)
        {
            // 功能 出貨 -> 更新機器餘額->判斷/更新機器狀態
            //回傳剩餘金額
            Machine.CustomerMoney -= productPrice;

            JudgeState(new Product().Price);
            return Machine.CustomerMoney; 
        }

    }
    public enum State
    {
        Waiting, // 不可退費/不可出貨
        Refundable, // 可退費/不可出貨
        Refundable_CanBeShipped,// 可退費/可出貨
    }
    public static class Machine
    {
        private static int customerMoney;

        public static State MachineState;

        public static int CustomerMoney { get => customerMoney; set => customerMoney = value; }



    }
    public class Product { 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Product() { 
            Name = "扭蛋";
            Description = "銘謝惠顧紙條";
            Price = 50;
        }

    }
}
