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

        //所持アイテム
        static List<Have> haveList = new List<Have>()
        {
            new Have(1, "ひのきのぼう", 0),
            new Have(2, "こんぼう", 0),
            new Have(3,"銅の剣",0)
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

                Console.WriteLine("所持金：{0}G", money);

                int haveCount = 0;
                Console.Write("所持アイテム：");

                for (int i = 0; i < haveList.Count; i++)
                {
                    if (haveList[i].Many != 0)
                    {
                        haveCount++;
                        Console.WriteLine("{0}：{1}個", haveList[i].Name, haveList[i].Many);
                    }
                    
                }

                if(haveCount == 0)
                {
                    Console.WriteLine("無し");
                }

                Console.WriteLine();

                for (int i = 0; i < itemList.Count; i++)
                {
                    Console.WriteLine("{0}：{1}：{2}G", itemList[i].Id, itemList[i].Name, itemList[i].Price);
                }

                Console.Write("買いたいものを入力(0で終了)＞");

                //数値を入力
                string count = Console.ReadLine();
                //整数に変換
                bool isSuccess1 = int.TryParse(count, out menu);

                if (isSuccess1 == false)
                {
                    //整数以外が入った場合
                    Console.WriteLine("*もう一度やり直してください*");
                    Console.ReadLine();
                    menu = 99;
                    Console.Clear();

                }
                else if (menu < 0||menu>itemList.Count)
                {
                    //0より小さい数またはアイテム数より多い値の場合
                    Console.WriteLine("*もう一度やり直してください*");
                    Console.ReadLine();
                    Console.Clear();
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
                        money -= itemList[0].Price;
                        haveList[0].Many++;
                    }

                    Console.Clear();
                }
                else if(menu == 2)
                {
                    if (money < itemList[1].Price)
                    {
                        Console.WriteLine("お金が足りません");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("お買い上げありがとうございます");
                        Console.ReadLine();
                        money-= itemList[1].Price;
                        haveList[1].Many++;
                    }

                    Console.Clear();
                }
                else if(menu == 3)
                {
                    if (money < itemList[2].Price)
                    {
                        Console.WriteLine("お金が足りません");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("お買い上げありがとうございます");
                        Console.ReadLine();
                        money-= itemList[2].Price;
                        haveList[2].Many++;
                    }

                    Console.Clear();
                }
                else if(menu==0)
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
