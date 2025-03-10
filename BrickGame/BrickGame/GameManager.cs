using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrickGame
{
    public class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;
        public List<Block> m_pBlock = new List<Block>();
        Random rand = new Random();

        public void Initialize()
        {
            if (m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }

            if (m_pBar == null)
            {
                m_pBar = new Bar();
                m_pBar.Initialize();
            }

            for(int i =0; i < 15; i++)
            {
                Block block = new Block();
                int x = rand.Next(3, 74);
                int y = rand.Next(2, 20);
                while (y == 18)
                {
                    y= rand.Next(2, 20);
                }
                block.SetPos(x,y);
                m_pBlock.Add(block);
                
            }



            m_pBall.SetBar(m_pBar);

        }

        public void BreakBlock(int index)
        {
            m_pBlock.RemoveAt(index);
        }

        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);
        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
            m_pBar.Render();
            for (int i = 0; i < m_pBlock.Count; i++)
                m_pBlock[i].Render();
        }

        public void Release()
        {
            m_pBall.Release();
            m_pBar.Release();
        }
    }
}
