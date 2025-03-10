using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();

            mainGame.SelectJob();
            mainGame.FirstScene();

        }
    }
}
