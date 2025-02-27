using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        struct Item
        {
            public string ItemName;
            public int ItemCount;

            public void PrintItem()
            {
                Console.WriteLine($"{ItemName} (x{ItemCount})");
            }
        }


        const int MAX_ITEMS = 10;

        //static string[] itemNames = new string[MAX_ITEMS];
        //static int[] itemCounts = new int[MAX_ITEMS];
        static Item[] items = new Item[MAX_ITEMS];
    
        static void AddItem(string name, int count)
        {
            for(int i =0; i <items.Length; i++)
            {
                if (items[i].ItemName == name)
                {
                    items[i].ItemCount += count;
                    return;
                }
            }
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].ItemName == null)
                {
                    items[i].ItemName = name;
                    items[i].ItemCount = count;
                    return;
                }
            }


            //for (int i = 0; i < MAX_ITEMS; i++)
            //{
            //    if (itemNames[i] == name)
            //    {
            //        itemCounts[i] += count;
            //        return;
            //    }
            //}

            //for (int i = 0; i < MAX_ITEMS; i++)
            //{
            //    if (itemNames[i] == null)
            //    {
            //        itemNames[i] = name;
            //        itemCounts[i] = count;
            //        return;
            //    }
            //}

            Console.WriteLine("인벤토리가 가득 찼습니다.");


        }

        static void RemoveItem(string name, int count)
        {
            for(int i =0; i <items.Length; i++)
            {
                if (items[i].ItemName == name)
                {
                    if (items[i].ItemCount >= count)
                    {
                        items[i].ItemCount -= count;
                        if (items[i].ItemCount == 0)
                        {
                            items[i].ItemName = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다!");
                        return;
                    }
                }
            }

            //for (int i = 0; i < MAX_ITEMS; i++)
            //{
            //    if (itemNames[i] == name)
            //    {
            //        if (itemCounts[i] >= count)
            //        {
            //            itemCounts[i] -= count;
            //            if (itemCounts[i] == 0)
            //            {
            //                itemNames[i] = null;
            //            }
            //            return;
            //        }
            //        else
            //        {
            //            Console.WriteLine("아이템 개수가 부족합니다!");
            //            return;
            //        }
            //    }
            //}

            Console.WriteLine("아이템을 찾을 수 없습니다!");
        }

        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmptry = true;

            for(int i =0; i<items.Length;i++)
            {
                if (items[i].ItemName != null)
                {
                    items[i].PrintItem();
                    isEmptry = false;
                }
            }

            //for(int i =0; i< MAX_ITEMS; i++)
            //{
            //    if (itemNames[i] != null)
            //    {
            //        Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
            //        isEmptry = false;
            //    }
            //}

            if(isEmptry)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }



        static void Main(string[] args)
        {


            AddItem("포션", 5);
            AddItem("칼", 1);
            AddItem("포션", 3);

            ShowInventory();

            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            RemoveItem("포션", 2);
            ShowInventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);

            ShowInventory();


            //테스트: 모든 포션 제거
            Console.WriteLine("포션 7개 사용(초과 사용 테스트)");
            RemoveItem("포션", 7);
            ShowInventory();
            Console.WriteLine("포션 6개 사용");
            RemoveItem("포션", 6);
            ShowInventory();
        }
    }
}
