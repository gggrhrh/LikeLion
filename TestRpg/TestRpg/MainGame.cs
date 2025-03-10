using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRpg
{
    class MainGame
    {
        Player player;
        FieldMap fieldMap;

        public void SelectJob()
        {
            int input = 0;

            player = new Player();

            Console.WriteLine("====== Text RPG ======");
            Console.WriteLine("직업을 선택하세요. ( 1. 기사 2. 마법사 3. 도적 )");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    player.SetPlayer("기사", 100, 15);
                    break;
                case 2:
                    player.SetPlayer("마법사", 85, 20);
                    break;
                case 3:
                    player.SetPlayer("도적", 90, 17);
                    break;
            }
        }

        public void FirstScene()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1. 사냥터  2. 종료 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 2)
                    break;

                if (input == 1)
                {
                    fieldMap = new FieldMap();
                    fieldMap.GetPlayer(ref player);
                    fieldMap.SecondScene();
                }

            }

        }


    }
}
