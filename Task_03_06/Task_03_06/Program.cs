using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame maingame = new MainGame();
            maingame.SetPlayer();
            maingame.Playing();

        }
    }
}
