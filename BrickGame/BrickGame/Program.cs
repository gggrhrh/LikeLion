using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();

        public static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            GameManager gm = new GameManager();
            Ball ball = new Ball();

            gm.Initialize();
            Console.SetCursorPosition(0,0);
            Console.WriteLine(gm.m_pBlock.Count + " " + ball.m_pBlock.Count);
            Thread.Sleep(10000);




            int Curr = Environment.TickCount;

            while (true)
            {
                if (Curr + 50 < Environment.TickCount)
                {
                    Curr = Environment.TickCount;

                    gm.Progress();
                    gm.Render();
                }
            }


        }
    }
}
