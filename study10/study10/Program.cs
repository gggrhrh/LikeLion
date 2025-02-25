using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("---------- 대장장이 키우기 ----------");
            Console.WriteLine("-------------------------------------");
            Console.ReadLine();

            int pMoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 나무캐기\n2. 장비뽑기\n3. 나가기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)\n뒤로가기 (x)");

                        string str = Console.ReadLine();

                        pMoney += 100;
                        Console.WriteLine("소지금 : " + pMoney);

                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            Thread.Sleep(1000);
                            break;
                        }

                    }//while(true)

                }//if(input == 1)

                else if (input == 2)
                {
                    if (pMoney >= 1000)
                    {
                        pMoney -= 1000;
                        for (int i = 0; i < 20; i++)
                        {
                            rnd = rand.Next(0, 100);

                            if (rnd == 0)
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd > 0 && rnd <= 5)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd > 5 && rnd <= 15)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd > 15 && rnd <= 35)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd > 35 && rnd <= 65)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(500);
                        }//for (int i = 0; i < 20; i++)
                        

                    }//if (pMoney >= 1000)
                    else
                    {
                        Console.WriteLine("돈이 부족합니다.\n");
                        Thread.Sleep(1000);
                    }


                }//else if (input == 2)

                else if(input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }

            }//while(true)


        }
    }
}
