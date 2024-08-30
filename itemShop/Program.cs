using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemShop
{
    internal class Program
    {
        //所持金
        int money=1000;

        //アイテム
        List<Item> itemList = new List<Item>() {
    new Item(1, "ひのきのぼう", 80),
    new Item(2, "こんぼう", 300),
    new Item(3,"銅の剣",500)
};

        static void Main(string[] args)
        {
            Console.WriteLine("いらっしゃいませ。");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("何をお探しですか？");

            //キー入力
            Console.ReadLine();
        }
    }
}
