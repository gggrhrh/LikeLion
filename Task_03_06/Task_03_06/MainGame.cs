using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03_06
{
    class MainGame
    {
        Player player;
        FieldMap fieldMap;

        public void SetPlayer()
        {
            int input = 0;

            player = new Player();
            Console.WriteLine("======== Text RPG ========");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 궁수");
            Console.Write("직업을 선택하세요 : ");
            input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1:
                    player.Name = "전사";
                    player.Hp = 100;
                    player.Attack = 15;
                    player.Defence = 8;
                    break;
                case 2:
                    player.Name = "마법사";
                    player.Hp = 85;
                    player.Attack = 23;
                    player.Defence = 5;
                    break;
                case 3:
                    player.Name = "궁수";
                    player.Hp = 90;
                    player.Attack = 20;
                    player.Defence = 6;
                    break;

            }

            
        }

        public void Playing()
        {
            int input = 0;

            while(true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1. 사낭터  2. 종료 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                    break;

                else if(input == 1)
                {
                    fieldMap = new FieldMap();
                    fieldMap.SetPlayer(ref player);

                    fieldMap.SelectField();
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                    Thread.Sleep(1000);
                }

            }


        }


    }
}
