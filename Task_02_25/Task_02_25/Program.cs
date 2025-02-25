using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_02_25
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 창 크기 설정
            Console.SetWindowSize(80, 25); //x 80 , y 25

            //콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; //커서 숨기기

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rand = new Random();

            string nickname = "";
            int gold = 1000;
            int health = 100;
            int maxHealth = 100;
            int power = 10;
            int myweaponAddpower = 0;
            int curpower = 0;
            int level = 1;
            int exp = 0;
            int maxExp = 10;
            string myweapon = "";
            int myweaponcode = 0;
            int input;
            bool isAlive = true;

            Console.WriteLine(" ⚔️🛡️ 모험가 어드벤처 🛡️⚔️ ");
            Thread.Sleep(1000);
            Console.Write("당신의 이름을 입력해주세요 : ");
            nickname = Console.ReadLine();

            while (isAlive)
            {
                //초기화
                if (health > maxHealth)
                    health = maxHealth;

                curpower = power + myweaponAddpower; //현재 공격력
                //초기화

                Console.Clear();
                Console.WriteLine($"닉네임 : {nickname} | 레벨 : {level} | 경험치 : {exp} / {maxExp}" +
                    $"\n체력 : {health} / {maxHealth} | 공격력 : {curpower} | 보유금액 : {gold} | 보유무기 : {myweapon}\n\n");

                Console.WriteLine("1. 탐험하기 🏕️");
                Console.WriteLine("2. 상점가기 🛒");
                Console.WriteLine("3. 레벨업 🆙");
                Console.WriteLine("4. 게임 종료 🚫");
                Console.Write("입력 : ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    while (true)
                    {
                        //초기화
                        if (health > maxHealth)
                            health = maxHealth;

                        curpower = power + myweaponAddpower; //현재 공격력
                        //초기화


                        Console.Clear();
                        Console.WriteLine($"닉네임 : {nickname} | 레벨 : {level} | 경험치 : {exp} / {maxExp}" +
                                $"\n체력 : {health} / {maxHealth} | 공격력 : {curpower} | 보유금액 : {gold} | 보유무기 : {myweapon}\n\n");

                        Console.WriteLine("\n1. 산으로 탐험하기 ⛰️ (몬스터와 전투 확률 UP)");
                        Console.WriteLine("2. 바다로 탐험하기 🌊 (보물 발견 확률 UP)");
                        Console.WriteLine("3. 뒤로가기 ◀️");
                        Console.Write("입력하기 : ");

                        int adveninput = int.Parse(Console.ReadLine());

                        if (adveninput == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("⛰️ 산으로 탐험을 떠납니다.");
                            Thread.Sleep(500);
                            Console.WriteLine("⛰️ 산으로 탐험을 떠납니다..");
                            Thread.Sleep(500);
                            Console.WriteLine("⛰️ 산으로 탐험을 떠납니다...");
                            Thread.Sleep(500);
                            Console.WriteLine("⛰️ 산으로 탐험을 떠납니다....");

                            int eventChance = rand.Next(1, 101); //1~100 랜덤 이벤트 발생

                            if (eventChance <= 50)   //몬스터
                            {
                                int monChance = rand.Next(1, 11);
                                int monlv = 0;
                                int monatt = 0;
                                int monhp = 0;
                                int reward = 0;
                                int rewardExp = 0;
                                if (monChance <= 1) //lv1
                                {
                                    monlv = 1;
                                    monhp = rand.Next(5, 16);
                                    monatt = rand.Next(5, 11);
                                    reward = rand.Next(100, 151);
                                    rewardExp = rand.Next(1, 4);
                                }
                                else if (monChance <= 4) //lv2
                                {
                                    monlv = 2;
                                    monhp = rand.Next(10, 21);
                                    monatt = rand.Next(10, 21);
                                    reward = rand.Next(150, 251);
                                    rewardExp = rand.Next(3, 8);
                                }
                                else if (monChance <= 7) //lv3
                                {
                                    monlv = 3;
                                    monhp = rand.Next(20, 51);
                                    monatt = rand.Next(15, 31);
                                    reward = rand.Next(200, 501);
                                    rewardExp = rand.Next(5, 11);
                                }
                                else if (monChance <= 9) //lv4
                                {
                                    monlv = 4;
                                    monhp = rand.Next(35, 81);
                                    monatt = rand.Next(25, 51);
                                    reward = rand.Next(300, 701);
                                    rewardExp = rand.Next(10, 18);
                                }
                                else //lv5
                                {
                                    monlv = 5;
                                    monhp = rand.Next(70, 151);
                                    monatt = rand.Next(50, 101);
                                    reward = rand.Next(500, 1001);
                                    rewardExp = rand.Next(20, 31);
                                }

                                Console.WriteLine($"LV {monlv} | HP {monhp} | 공격력 {monatt}인 몬스터와 마주쳤습니다.");
                                Thread.Sleep(2000);

                                if (curpower < monhp)
                                {
                                    Console.WriteLine($"전투에서 패배했습니다. 체력 -{monatt}");
                                    health -= monatt;
                                }
                                else
                                {
                                    Console.WriteLine($"전투에서 승리했습니다. {reward}골드와 {rewardExp}경험치를 획득합니다");
                                    gold += reward;
                                    exp += rewardExp;
                                }

                            }// if(eventChance <= 60)   //몬스터

                            else if (eventChance <= 80) //보물
                            {
                                int reward = rand.Next(100, 301); //100~300골드
                                Console.WriteLine($"💰 보물을 발견했습니다! ({reward} 골드 획득)");
                                gold += reward;
                            }//else if (eventChance <= 90) //보물

                            else if(eventChance <= 90)  //경험치
                            {
                                int reward = rand.Next(100, 301);
                                int rewardExp = rand.Next(1, 16);
                                Console.WriteLine($"몬스터의 시체를 발견했습니다! ({reward}골드, {rewardExp}경험치 획득)");
                                gold += reward;
                                exp += rewardExp;
                            }

                            else
                            {
                                int heal = rand.Next(1, 31); //10~30 체력 회복
                                Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (+{heal} 체력)");
                                health += heal;
                            }

                            if (health <= 0)
                            {
                                Console.WriteLine("\n 💀체력이 0이 되어 사망했습니다... 게임 오버!");
                                isAlive = false;
                            }

                            Thread.Sleep(3000);
                           
                        }//if (adveninput == 1)

                        else if (adveninput == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("🌊 바다로 탐험을 떠납니다.");
                            Thread.Sleep(500);
                            Console.WriteLine("🌊 바다로 탐험을 떠납니다..");
                            Thread.Sleep(500);
                            Console.WriteLine("🌊 바다로 탐험을 떠납니다...");
                            Thread.Sleep(500);
                            Console.WriteLine("🌊 바다로 탐험을 떠납니다....");

                            int eventChance = rand.Next(1, 101); //1~100 랜덤 이벤트 발생

                            if (eventChance <= 50)   //몬스터
                            {
                                int monChance = rand.Next(1, 11);
                                int monlv = 0;
                                int monatt = 0;
                                int monhp = 0;
                                int reward = 0;
                                int rewardExp = 0;
                                if (monChance <= 1) //lv1
                                {
                                    monlv = 1;
                                    monhp = rand.Next(5, 16);
                                    monatt = rand.Next(5, 11);
                                    reward = rand.Next(100, 151);
                                    rewardExp = rand.Next(1, 4);
                                }
                                else if (monChance <= 4) //lv2
                                {
                                    monlv = 2;
                                    monhp = rand.Next(10, 21);
                                    monatt = rand.Next(10, 21);
                                    reward = rand.Next(150, 251);
                                    rewardExp = rand.Next(3, 8);
                                }
                                else if (monChance <= 7) //lv3
                                {
                                    monlv = 3;
                                    monhp = rand.Next(20, 51);
                                    monatt = rand.Next(15, 31);
                                    reward = rand.Next(200, 501);
                                    rewardExp = rand.Next(5, 11);
                                }
                                else if (monChance <= 9) //lv4
                                {
                                    monlv = 4;
                                    monhp = rand.Next(35, 81);
                                    monatt = rand.Next(25, 51);
                                    reward = rand.Next(300, 701);
                                    rewardExp = rand.Next(10, 18);
                                }
                                else //lv5
                                {
                                    monlv = 5;
                                    monhp = rand.Next(70, 151);
                                    monatt = rand.Next(50, 101);
                                    reward = rand.Next(500, 1001);
                                    rewardExp = rand.Next(20, 31);
                                }

                                Console.WriteLine($"LV {monlv} | HP {monhp} | 공격력 {monatt}인 몬스터와 마주쳤습니다.");
                                Thread.Sleep(2000);

                                if (curpower < monhp)
                                {
                                    Console.WriteLine($"전투에서 패배했습니다. 체력 -{monatt}");
                                    health -= monatt;
                                }
                                else
                                {
                                    Console.WriteLine($"전투에서 승리했습니다. {reward}골드와 {rewardExp}경험치를 획득합니다");
                                    gold += reward;
                                    exp += rewardExp;
                                }

                            }// if(eventChance <= 60)   //몬스터

                            else if (eventChance <= 80) //보물
                            {
                                int reward = rand.Next(100, 301); //100~300골드
                                Console.WriteLine($"💰 보물을 발견했습니다! (+{reward} 골드)");
                                gold += reward;
                            }//else if (eventChance <= 90) //보물

                            else if (eventChance <= 90)  //경험치
                            {
                                int reward = rand.Next(100, 301);
                                int rewardExp = rand.Next(1, 16);
                                Console.WriteLine($"몬스터의 시체를 발견했습니다! ({reward}골드, {rewardExp}경험치 획득)");
                                gold += reward;
                                exp += rewardExp;
                            }

                            else
                            {
                                int heal = rand.Next(1, 31); //10~30 체력 회복
                                Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (+{heal} 체력)");
                                health += heal;
                            }

                            if (health <= 0)
                            {
                                Console.WriteLine("\n 💀체력이 0이 되어 사망했습니다... 게임 오버!");
                                isAlive = false;
                            }

                            Thread.Sleep(3000);

                        }//else if (adveninput == 2)

                        else if (adveninput == 3)
                        {
                            Console.WriteLine("메인 메뉴로 갑니다...");
                            Thread.Sleep(2000);
                            break;
                        }//else if(shopinput == 3)
                        else
                        {
                            Console.WriteLine("잘 못 입력하셨습니다.");
                            Console.WriteLine("메인 메뉴로 갑니다...");
                            Thread.Sleep(2000);
                            break;
                        }

                    }// while (true)

                }//if (input == 1)

                else if (input == 2)
                {
                    while (true)
                    {
                        //초기화
                        if (health > maxHealth)
                            health = maxHealth;

                        curpower = power + myweaponAddpower; //현재 공격력
                        //초기화

                        Console.Clear();
                        Console.WriteLine($"닉네임 : {nickname} | 레벨 : {level} | 경험치 : {exp} / {maxExp}" +
                            $"\n체력 : {health} / {maxHealth} | 공격력 : {curpower} | 보유금액 : {gold} | 보유무기 : {myweapon}\n\n");

                        Console.WriteLine("\n1. 랜덤장비뽑기 🎲 (1000골드)");
                        Console.WriteLine("2. 포션마시기 🍺 (100골드, 체력 +20)");
                        Console.WriteLine("3. 뒤로가기 ◀️");
                        Console.Write("입력하기 : ");

                        int shopinput = int.Parse(Console.ReadLine());

                        if (shopinput == 1)
                        {
                            if (gold >= 1000)
                            {
                                gold -= 1000;
                                Console.Clear();
                                Console.WriteLine("🎲 장비를 뽑습니다.");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("🎲 장비를 뽑습니다..");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("🎲 장비를 뽑습니다...");
                                Thread.Sleep(500);
                                Console.Clear();

                                int rnd = rand.Next(1, 101); //1~100랜덤
                                string weapon = "";
                                int weaponcode = 0;
                                int weaponAddpower = 0;

                                if (rnd == 1)
                                {
                                    weapon = "무한의 대검(SSS)";
                                    weaponcode = 6;
                                    weaponAddpower = 100;

                                }
                                else if (rnd <= 5)
                                {
                                    weapon = "삼위일체(SS)";
                                    weaponcode = 5;
                                    weaponAddpower = 50;
                                }
                                else if (rnd <= 15)
                                {
                                    weapon = "칠흑의 양날 도끼(S)";
                                    weaponcode = 4;
                                    weaponAddpower = 20;
                                }
                                else if (rnd <= 25)
                                {
                                    weapon = "B.F대검(A)";
                                    weaponcode = 3;
                                    weaponAddpower = 10;
                                }
                                else if (rnd <= 55)
                                {
                                    weapon = "도란의 검(B)";
                                    weaponcode = 2;
                                    weaponAddpower = 5;
                                }
                                else
                                {
                                    weapon = "단검(C)";
                                    weaponcode = 1;
                                    weaponAddpower = 3;
                                }

                                if (myweaponcode < weaponcode)
                                {
                                    Console.WriteLine($"{weapon}을 뽑으셨습니다. " +
                                        $"보유하던 {myweapon}을 버리고 {weapon}으로 교체합니다.");

                                    myweapon = weapon;
                                    myweaponcode = weaponcode;
                                    myweaponAddpower = weaponAddpower;
                                }
                                else
                                {
                                    Console.WriteLine($"{weapon}을 뽑으셨습니다. 보유하던 {myweapon}을 사용합니다.");
                                    Thread.Sleep(1000);
                                }

                            }//if(gold >= 1000)

                            else
                            {
                                Console.WriteLine("골드가 부족합니다. ❌");
                            }
                            Thread.Sleep(2000);

                        }// if(shopinput == 1)

                        else if (shopinput == 2)
                        {
                            if (gold >= 100)
                            {
                                gold -= 100;
                                Console.Clear();
                                Console.WriteLine("🍺 포션을 마십니다.");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("🍺 포션을 마십니다..");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("🍺 포션을 마십니다...");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("♥️ 체력을 20 회복했습니다.");
                                health += 20;
                            }
                            else
                            {
                                Console.WriteLine("골드가 부족합니다. ❌");
                            }

                            Thread.Sleep(2000);
                        }//else if(shopinput == 2)

                        else if (shopinput == 3)
                        {
                            Console.WriteLine("메인 메뉴로 갑니다...");
                            Thread.Sleep(2000);
                            break;
                        }//else if(shopinput == 3)
                        else
                        {
                            Console.WriteLine("잘 못 입력하셨습니다...");
                            Console.WriteLine("메인 메뉴로 갑니다...");
                            Thread.Sleep(2000);
                            break;
                        }

                    }//while (true)

                }//else if(input == 2)

                else if (input == 3)
                {
                    if(exp >= maxExp)
                    {
                        maxExp += (level*10);
                        maxHealth += (level * 10);
                        health = maxHealth; //레벨업시 풀피
                        power += level;
                        level++;
                        exp = 0;
                        Console.WriteLine($"레벨이 {level}로 올랐습니다");
                    }
                    else
                    {
                        Console.WriteLine("필요한 경험치가 부족합니다.");
                        Thread.Sleep(2000);
                    }
                }//else if(input == 3)

                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Thread.Sleep(2000);
                    Environment.Exit(1);
                }

            }//while(isAlive)

        }//static void Main(string[] args)
    }
}
