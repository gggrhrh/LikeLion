using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestRpg
{
    class FieldMap
    {
        Player player;
        Monster monster;

        public void GetPlayer(ref Player player)
        {
            this.player = player;
        }

        public void SecondScene()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                MapDraw();
                input = int.Parse(Console.ReadLine());

                if (input == 4)
                    break;
                if (input >= 1 && input <= 3)
                {
                    CreateMonster(input);
                    FightScene();
                }
            }
        }

        public void MapDraw()
        {
            player.Render();

            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("================");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public void CreateMonster(int input)
        {
            if (monster == null)
                monster = new Monster();

            switch (input)
            {
                case 1:
                    monster.SetMonster("초보몹", 30, 3);
                    break;
                case 2:
                    monster.SetMonster("중수몹", 60, 6);
                    break;
                case 3:
                    monster.SetMonster("고수몹", 90, 9);
                    break;

            }
        }

        public void FightScene()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();
                Console.WriteLine("1. 공격 2. 도망");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    player.TakeDamage(monster.Attack);
                    monster.TakeDamage(player.Attack);
                }
                if (player.Hp <= 0)
                {
                    Console.WriteLine("Death...");
                    Thread.Sleep(1000);
                    player.Hp = 100;
                    monster = null;
                    break;
                }

                if (input == 2 || monster.Hp <= 0)
                {
                    monster = null;
                    break;
                }
            }

        }
    }
}
