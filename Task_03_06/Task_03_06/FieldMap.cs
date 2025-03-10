using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03_06
{
    class FieldMap
    {
        Player player;
        Monster monster;

        public void SetPlayer(ref Player player)
        {
            this.player = player;
        }


        public void SelectField()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                DrawField();

                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 3)
                {
                    CreateMonster(input);
                    FightField();
                }
                else if (input == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                    Thread.Sleep(500);
                }


            }


        }

        public void DrawField()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 이전으로");
        }

        public void CreateMonster(int input)
        {
            monster = new Monster();

            switch (input)
            {
                case 1:
                    monster.Name = "초보몹";
                    monster.Hp = 30;
                    monster.Attack = 5;
                    monster.Defence = 3;
                    break;
                case 2:
                    monster.Name = "중수몹";
                    monster.Hp = 60;
                    monster.Attack = 10;
                    monster.Defence = 5;
                    break;
                case 3:
                    monster.Name = "고수몹";
                    monster.Hp = 100;
                    monster.Attack = 18;
                    monster.Defence = 8;
                    break;
            }


        }

        public void FightField()
        {
            int input = 0;

            while (player.Hp > 0)
            {
                Console.Clear();
                player.Render();
                monster.Render();

                Console.WriteLine("1. 공격  2.도망가기 : ");
                input = int.Parse(Console.ReadLine());

                
                if(input == 1)
                {
                    monster.TakeDamage(player.Attack);
                    player.TakeDamage(monster.Attack);

                    if (player.Hp <= 0)
                    {
                        player.Hp = 100;
                        break;
                    }         

                }

                if (input == 2 || monster.Hp <= 0)
                {
                    monster = null;
                    break;
                }

            }
        }

    }//class FieldMap

}
