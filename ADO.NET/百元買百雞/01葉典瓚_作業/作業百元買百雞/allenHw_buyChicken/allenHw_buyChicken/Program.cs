// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("題目 百元買百雞，公雞5元/隻，母雞5元/隻，小雞1元/3隻 \n");
Console.WriteLine("雞的總數100隻，總共花100元，問3種雞的購買組合? \n");

decimal RoosterNum = 0; // 公雞數量
decimal henNum = 0; // 母雞數量
decimal chickGroup = 0; //小雞組數(1組3隻)
string result = string.Empty;
for (RoosterNum = 0; RoosterNum< 21; RoosterNum++) {
    decimal q = 100 - RoosterNum; // 限制條件1: 數量quantity
    decimal m = 100 - (5 * RoosterNum); // 限制條件2: 金額 money
    henNum = (3 * m - q) / 8;
    chickGroup = (3 * q - m) / 8;
    if (henNum >= 0 && chickGroup >= 0 && (henNum % 1) == 0 && (chickGroup % 1) == 0) {
        result += $"公雞數量: {RoosterNum}, 母雞數量: {henNum}, 小雞組數(1組3隻): {chickGroup}, 小雞數量: {chickGroup*3} \n";
    }
}
Console.WriteLine(result);
Console.ReadLine();

