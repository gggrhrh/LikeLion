using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("엔터를 치면 스토리가 시작됩니다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000); 
            Console.Clear();
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중....");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중.....");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중......");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중.......");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine(" ------ 최강의 마법사 ------ ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("나는 최강의 마법사이다.");
            Thread.Sleep(1000);
            Console.WriteLine("모든 사람이 마법을 쓸줄 아는 이 마법세계에서 " +
                "불, 물, 바람, 땅 4가지 원소을 모두 마스터한 가장 강한 마법사이다." +
                "\n각 원소의 왕국을 다스리고 균형을 유지하고 있었다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("평화롭던 어느날....");
            Thread.Sleep(2000);
            Console.WriteLine("예언자 : 4대 원소를 모두 지닌 가장 강한자가 이 세계를 멸망시킬것이다~!!");
            Thread.Sleep(3000);
            Console.WriteLine("(약간의 정적...) ");
            Thread.Sleep(1000);
            Console.WriteLine("각 원소의 왕들 : 그 사람 밖에 없군...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n\n\n               ------ 1주일 후 ------ \n\n\n");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("4원소 왕국이 모여 회의를 한다.");
            Thread.Sleep(2000);
            Console.WriteLine("\n 1. 그 자를 봉인하자 \n 2. 안된다. 그 자는 세계의 균형을 유지하고 있다.\n (1, 2번 중에 입력하세요.)");
            string chooseNum = Console.ReadLine();

            Console.Clear();
            if(chooseNum == "1")
            {
                Console.WriteLine("그렇게 나는 4원소의 왕국에 의해 힘이 봉인되었다.");
                Thread.Sleep(3000);
                Console.WriteLine("그러나 힘이 봉인되고 난 후 세계는 힘의 불균형을 가지게 되고" +
                " 각 왕국끼리 서로 싸우다 이 세계는 멸망하게 된다....");
                Thread.Sleep(4000);
                Console.WriteLine("\n                  ------ The End ------ ");
            }
            else if (chooseNum == "2")
            {
                Console.WriteLine("최강의 마법사는 예언자의 말대로 암흑에 잠식당하여 이 세계를 멸망시키게 된다...");
                Thread.Sleep(3000);
                Console.WriteLine("\n                  ------ The End ------ ");
            }
            else
            {
                Console.WriteLine("잘못입력하셨습니다. 세계는 당신때문에 멸망하였습니다.");
            }
            Console.ReadLine();

        }
    }
}
