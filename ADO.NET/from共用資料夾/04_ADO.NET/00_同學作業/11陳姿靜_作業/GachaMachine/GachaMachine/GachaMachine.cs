namespace GachaMachine
{
    public class GachaMachine
    {
        static void Main(string[] args)
        {

        }
        int dallar = 0;
        string result;
        int cost = 50;
        bool open = true;
        bool close=false;
        string controlRefundMoney, controlship;
        public string Gacha()
        {
            if (dallar < cost)
            {
                controlRefundMoney = open.ToString();
                controlship = close.ToString();
                result = "State:InsufficientAmountState有投幣,但金額還不足夠" + "\r\n" + "Money:" + dallar;
            }
            else if (dallar == 0)
            {
                controlRefundMoney = close.ToString();
                controlship = close.ToString();
                result = "State:StandByState 機器沒在工作,等待下一個客人操作" + "\r\n" + "Money:" + dallar;
            }
            else
            {
                controlRefundMoney = open.ToString();
                controlship = open.ToString();

                result = "State:ReadyToship投入足夠金額,等待客人指令就出貨" + "\r\n" + "Money:" + dallar;
            }
            return result;
            return controlRefundMoney;
            return controlship;
        }
    }
}