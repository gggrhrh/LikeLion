using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_28
{
    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;
        public int playerY;
        public Bullet[] bullet = new Bullet[20];

        ConsoleKeyInfo keyInfo;

        public Player()
        {
            playerX = 0;
            playerY = 11;

            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i] = new Bullet();   //각자 불렛 임명해주기
                //불렛들 초기화 해주기
                bullet[i].x = 0;
                bullet[i].y = 0;
                bullet[i].fire = false;
            }

        }

        public void DrawPlayer()
        {
            string[] player = new string[] { ",____,", "//'", "~" };
            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.Write(player[i]);
            }

        }

        public void DrawBullet()
        {
            string sBullet = "＊";

            for (int i = 0; i < bullet.Length; i++)
            {
                if (bullet[i].fire == true) //true 발사
                {
                    Console.SetCursorPosition(bullet[i].x, bullet[i].y);
                    Console.Write(sBullet);

                    bullet[i].x++;

                    if (bullet[i].x > 78)
                        bullet[i].fire = false;

                }
            }
        }

        public void KeyControl()
        {
            int pressKey;  //정수형 변수선언 키값 받을거임 

            if (Console.KeyAvailable) //키가 눌렸을때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽


                switch (pressKey)
                {
                    case 72:  //위쪽방향 아스키코드                    
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        //왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        //오른쪽
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80: //아래
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32: //스페이스바
                        //총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (bullet[i].fire == false)
                            {
                                bullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                bullet[i].x = playerX + 5;
                                bullet[i].y = playerY + 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }

                        break;

                    case 27:
                        Environment.Exit(0);
                        break;
                }

            }//if (Console.KeyAvailable)

        }//public void KeyControl()

        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for(int i = 0; i< bullet.Length; i++)
            {
                if (bullet[i].fire == true)
                {
                    if (bullet[i].y == enemy.enemyY)
                    {
                        if (bullet[i].x <= enemy.enemyX +1
                            && bullet[i].x >= enemy.enemyX -1)
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);
                            bullet[i].fire = false;
                        }
                    }
                }
            }
        }


        public void GameUpdate()
        {
            KeyControl();
            DrawPlayer();
            DrawBullet();
        }

    }//public class Player

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()  //적 좌표 초기화
        {
            enemyX = 77;
            enemyY = 12;

        }

        public void DrawEnemy()
        {
            string enemy = "ª▣ª";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void MoveEnemy()
        {
            Random rand = new Random();

            enemyX--;

            if (enemyX < 3)
            {
                enemyX = 77;
                enemyY = rand.Next(2, 22);
            }

        }// public void MoveEnemy()

    }//public class Enemy

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player();
            Enemy enemy = new Enemy();

            int drTime = Environment.TickCount;

            while (true)
            {
                if (drTime + 50 < Environment.TickCount)
                {
                    drTime = Environment.TickCount;
                    Console.Clear();

                    player.GameUpdate();

                    enemy.DrawEnemy();
                    enemy.MoveEnemy();
                }

                player.ClashEnemyAndBullet(enemy);

            }
        }
    }

}
