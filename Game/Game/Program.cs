using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static int Score = 0;
        public static int Heart = 3;
        public static int[] OX = new int[15];

        static void SetStart()
        {
            Console.SetCursorPosition(32, 22);
            Console.Write("←--");
            Console.SetCursorPosition(46, 22);
            Console.Write("--→");
            Console.SetCursorPosition(20, 3);
            Console.Write("==========================================");
        }

        static void RefreshScoreHeart()
        {

        }

        static void RefreshOX()
        {
            Console.Clear();

            SetStart();

        }

        static void KeyDown(ConsoleKey consolekey)
        {
            if (consolekey == ConsoleKey.LeftArrow)
            {
                if (OX[0] == 0)
                    AddScore();
                else
                    LoseHeart();
            }

            else if (consolekey == ConsoleKey.RightArrow)
            {
                if (OX[0] == 1)
                    AddScore();
                else
                    LoseHeart();
            }

            RefreshOX();

        }

        static void GameOver()
        {

        }

        static void AddScore()
        {
            Score += 10;
        }
        static void LoseHeart()
        {
            Heart--;
            if (Heart <= 0)
            {
                GameOver();
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            SetStart();

            Random rand = new Random();



            for (int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(40, 19 - i);
                OX[i] = rand.Next(0, 2);
            }

            RefreshOX();

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            keyInfo = Console.ReadKey(true);

        }
    }
}
