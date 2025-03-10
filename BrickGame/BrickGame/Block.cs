using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Block
    {
        public int blockX;
        public int blockY;

        public void SetPos(int x , int y)
        {
            blockX = x;
            blockY = y;
        }

        public void Render()
        {
            Program.gotoxy(blockX, blockY);
            Console.Write("■");
        }


    }
}
