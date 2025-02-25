using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {

            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말");
            //        break;
            //}


            //캐릭터를 선택하세요 (1. 검사 2. 마법사 3. 도적)
            //1
            //검사
            //공격력 100
            //방어력 90

            //Console.WriteLine("캐릭터를 선택하세요 (1. 검사 2. 마법사 3. 도적)");

            //int iInput = int.Parse(Console.ReadLine());

            //string strJob = "";
            //float attack = 0.0f;
            //float defence = 0.0f;

            //switch(iInput)
            //{
            //    case 1:
            //        strJob = "검사";
            //        attack = 100;
            //        defence = 90;
            //        break;
            //    case 2:
            //        strJob = "마법사";
            //        attack = 110;
            //        defence = 80;
            //        break;
            //    case 3:
            //        strJob = "도적";
            //        attack = 115;
            //        defence = 70;
            //        break;
            //}

            //Console.WriteLine($"직업 : {strJob}\n공격력 : {attack}\n방어력 : {defence}");


            //반복문

            //for(int i = 0; i <= 9; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}

            //int sum = 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //int count = 1; //초기화

            //while (count <= 5) //조건식
            //{
            //    Console.WriteLine("Count : " + count);

            //    count++; //증가,감소

            //    if (count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }

            //}


            //Console.WriteLine("Count : " + count);


            //Random rand = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int randomNumber = rand.Next(0, 10);
            //    Console.WriteLine("0이상 10미만의 랜덤 정수 : " + randomNumber);
            //}

            //Random rand = new Random();
            //string axeGrade = "";


            //for(int i = 0; i < 20; i++)
            //{
            //    int randomNumber = rand.Next(0, 100);
            //    if(randomNumber < 10)
            //    {
            //        axeGrade = "SSS";
            //    }
            //    else if(randomNumber >= 10 && randomNumber <= 50)
            //    {
            //        axeGrade = "SS";
            //    }
            //    else
            //    {
            //        axeGrade = "S";
            //    }

            //    Console.WriteLine("도끼 등급 : " + axeGrade);
            //    Thread.Sleep(500);
            //}

            //int x = 5;


            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다.");
            //    x--;
            //} while (x > 0);


            //break
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;    //탈출
            //    }

            //    Console.WriteLine(i);
            //}


            //continue
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 ==0)  //반복을 건너뛰고 다음으로 넘어간다. 뒷 명령어를 생략한다.
            //        continue;

            //    Console.WriteLine(i);
            //}


            ////goto
            //int n = 1;

            //start:

            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //start로 이동
            //}


        }
    }
}
