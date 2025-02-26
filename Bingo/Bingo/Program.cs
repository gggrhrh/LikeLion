using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();

            //int[] iArray = new int[25];

            //for (int i = 0; i < iArray.Length; i++)
            //{
            //    iArray[i] = i + 1;
            //}

            ////for (int i = 0; i < 5; i++)
            ////{
            ////    for (int j = 0; j < 5; j++)
            ////    {
            ////        Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            ////    }
            ////    Console.WriteLine();

            ////}

            //for (int i = 0; i < 100; i++)
            //{
            //    int iA = rand.Next(0, 25);
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;

            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //int input = 0;
            //int iCount = 0;
            //int iBingo = 0;

            //while (true)
            //{
            //    Console.Clear();

            //    //빙고판
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {

            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");

            //            }
            //        }
            //        Console.WriteLine();
            //    }//for (int i = 0; i < 5; i++)
            //    Console.WriteLine("빙고 숫자 : " + iBingo);
            //    Console.WriteLine("숫자를 입력하세요 : ");
            //    input = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < iArray.Length; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }

            //    }

            //    iBingo = 0;
            //    //빙고 체크 로직
            //    //가로 체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                ++iCount;
            //            }
            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //세로 체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i + j * 5] == 0)
            //            {
            //                ++iCount;
            //            }
            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //대각선 체크
            //    for (int i = 0; i < 5; i++)
            //    {

            //        if (iArray[(i + 1) * 4] == 0)
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }

            //    }

            //    iCount = 0;
            //    for (int i = 0; i < 5; i++)
            //    {

            //        if (iArray[i * 6] == 0)
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }

            //    }
            //    iCount = 0;

            //    if(iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고 성공");
            //        break;
            //    }


            //}//while (true)

            int[,] board = new int[5, 5];
            bool[,] marked = new bool[5, 5];

            int bingoCount = 0;

            Random random = new Random();

            int[] numbers = new int[25];

            //숫자 배정
            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //숫자 섞기
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);    //교환
            }

            //빙고판형성
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임 시작
            while (bingoCount < 5)
            {
                Console.Clear();

                Console.WriteLine("현재 빙고판");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1 ~ 25) : ");

                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true;
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        break;
                }//for(int i = 0; i<5; i++)

                bingoCount = 0;

                //가로 체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }

                //세로 체크
                for (int i = 0; i < 5; i++)
                {
                    bool colBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[j, i]) colBingo = false;

                    if (colBingo) bingoCount++;
                }

                //대각선 체크

                bool diag1Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, i]) diag1Bingo = false;

                if (diag1Bingo) bingoCount++;

                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;

                if (diag2Bingo) bingoCount++;


            }//while (bingoCount < 5)

            Console.WriteLine("빙고 5개 완성! 게임종료");

        }//static void Main(string[] args)
    }
}
