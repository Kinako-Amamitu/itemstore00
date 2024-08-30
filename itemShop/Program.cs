using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemShop
{
    internal class Program
    {


        //アイテム
       static List<Item> itemList = new List<Item>() {
    new Item(1, "ひのきのぼう", 80),
    new Item(2, "こんぼう", 300),
    new Item(3,"銅の剣",500)
};

        static void Main(string[] args)
        {
            //所持金
            int money = 1000;

            //選択
            int menu = 0;

            //再購入フラグ
            bool flag=false;

            Console.WriteLine("いらっしゃいませ。");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("何をお探しですか？");

            while (true)
            {
                if (flag==true)
                {
                    Console.WriteLine("他に欲しいものはありますか？？");
                }

                for (int i = 0; i < itemList.Count; i++)
                {
                    Console.WriteLine("{0}：{1}：{2}G", itemList[i].Id, itemList[i].Name, itemList[i].Price);
                }

                Console.Write("買いたいものを入力(99で終了)＞");

                //数値を入力
                string count = Console.ReadLine();
                //整数に変換
                bool isSuccess1 = int.TryParse(count, out menu);

                if (isSuccess1 == false)
                {
                    //整数以外が入った場合
                    Console.WriteLine("*もう一度やり直してください*");
                    Console.ReadLine();

                }
                else if (menu <= 0)
                {
                    //0もしくはそれより小さい数の場合
                    Console.WriteLine("*もう一度やり直してください*");
                    Console.ReadLine();
                }

                flag=true;

                if (menu == 1)
                {
                    if (money < itemList[0].Price)
                    {
                        Console.WriteLine("お金が足りません");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("お買い上げありがとうございます");
                        Console.ReadLine();
                    }

                    Console.Clear();
                }
                else if(menu == 2)
                {
                    if (money < itemList[0].Price)
                    {
                        Console.WriteLine("お金が足りません");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("お買い上げありがとうございます");
                        Console.ReadLine();
                    }

                    Console.Clear();
                }
                else if(menu == 3)
                {
                    if (money < itemList[0].Price)
                    {
                        Console.WriteLine("お金が足りません");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("お買い上げありがとうございます");
                        Console.ReadLine();
                    }

                    Console.Clear();
                }
                else if(menu==99)
                {
                    Console.WriteLine("ありがとうございました。");
                    break;
                }


            }

            //キー入力
            Console.ReadLine();
        }
    }
}
