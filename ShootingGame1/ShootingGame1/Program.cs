using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{


    class Program
    {


        static void SetSize()
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
        }

        struct Player
        {
            public string[] player;
            public int playerX;
            public int playerY;

            public void Draw()
            {
                for (int i = 0; i < player.Length; i++)
                {
                    //콘솔좌표 설정 플레이어X 플레이어Y
                    Console.SetCursorPosition(playerX, playerY + i);
                    //문자열배열 출력
                    Console.WriteLine(player[i]);
                }
            }

            public void KeyButton(ConsoleKey consoleKey)
            {
                if (consoleKey == ConsoleKey.UpArrow)
                {
                    if (playerY > 0)
                        playerY--;

                }
                else if (consoleKey == ConsoleKey.DownArrow)
                {
                    if (playerY < Console.WindowHeight - 1)
                        playerY++;
                }
                else if (consoleKey == ConsoleKey.LeftArrow)
                {
                    if (playerX > 0)
                        playerX--;
                }
                else if (consoleKey == ConsoleKey.RightArrow)
                {
                    if (playerX < Console.WindowWidth - 1)
                        playerX++;
                }
                else if (consoleKey == ConsoleKey.Spacebar)
                {
                    Console.Write("미사일키");
                }
                else if (consoleKey == ConsoleKey.Escape)
                    return;

            }

        }



        //static void DrawPlayer(string[] player, int x, int y)
        //{
        //    for (int i = 0; i < player.Length; i++)
        //    {
        //        //콘솔좌표 설정 플레이어X 플레이어Y
        //        Console.SetCursorPosition(x, y + i);
        //        //문자열배열 출력
        //        Console.WriteLine(player[i]);
        //    }
        //}

        static void Main(string[] args)
        {
            SetSize();

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;


            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;

            //구조체로 설정하기
            Player Splayer;
            Splayer.player = player;
            Splayer.playerX = playerX;
            Splayer.playerY = playerY;


            while (true)
            {

                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 100)
                {
                    // Console.WriteLine("1초루프");
                    Console.Clear();

                    //DrawPlayer(player, playerX, playerY);     //함수사용

                    //구조체 사용
                    
                    Splayer.Draw();

                    keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)

                    Splayer.KeyButton(keyInfo.Key);


                    ////방향키 입력에 따른 좌표 변경
                    //switch (keyInfo.Key)
                    //{
                    //    case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                    //    case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                    //    case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                    //    case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                    //    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    //    case ConsoleKey.Escape: return; //ESC키로 종료 

                    //}


                    prevSecond = currentSecond;//이전 시간 업데이트
                }





            }




        }
    }
}
