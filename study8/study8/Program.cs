using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int b = 3;

            ////전위 ++b , 후위 b++

            //Console.WriteLine("b의 값은 : " + (b++));

            //int x = 5, y = 10;


            //Console.WriteLine(x == y);  //false
            //Console.WriteLine(x != y);  //true
            //Console.WriteLine(x < y);   //true
            //Console.WriteLine(x > y);   //false
            //Console.WriteLine(x >= y);  //false
            //Console.WriteLine(x <= y);  //true

            //bool a = true;
            //bool b = false;
            //Console.WriteLine(a && b);  //And   (false)
            //Console.WriteLine(a || b);  //Or    (true)

            //a = !a;

            //Console.WriteLine(a);   //false

            //비트 연산자
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y); //AND 0001    1
            //Console.WriteLine(x | y); //OR  0111    7
            //Console.WriteLine(x ^ y); //XOR 0110    6
            //Console.WriteLine(~x);    //NOT 1111 1111 1010   -6


            //int value = 4;
            //Console.WriteLine(value << 1);  //왼쪽이동 0100 -> 1000 
            //Console.WriteLine(value >> 1);  //오른쪽 이동 0100 -> 0010

            //int a = 10, b = 20;

            //int max;

            //max = (a > b) ? a : b;  //삼항 연산자 조건문이 true 면 a fals 면 b

            //Console.WriteLine(max);

            //// 가정 ? true일때 : false일때;

            //int key = 1;

            //string str;
            //str = (key == 1) ? "문이 열렸습니다." : "문을 못열었습니다.";

            //Console.WriteLine(str);

            //int result = 10 + 2 * 5;    //20
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);  //60

            //int score = 95;

            //if(score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else
            //{
            //    Console.WriteLine("이프문이 끝났습니다.");
            //}

            //string GameID = "멋사검존";

            //if(GameID == "멋사검존")
            //{
            //    Console.WriteLine("아이디가 일치합니다.");
            //}
            //else
            //{
            //    Console.WriteLine("아이디가 일치하지 않습니다.");
            //}


            //int score = 60;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}

            Console.WriteLine("가지고있는 소지금을 입력하세요 : ");

            int userGold = Int32.Parse(Console.ReadLine());
            string typeSword = "";
            int attack = 100;

            if (0 < userGold && userGold <= 100)
            {
                typeSword = "무한의 대검";
                attack += 1;
            }
            else if (100 < userGold && userGold <= 200)
            {
                typeSword = "카타나";
                attack += 2;
            }
            else if (200 < userGold && userGold <= 300)
            {
                typeSword = "진은검";
                attack += 3;
            }
            else if (300 < userGold && userGold <= 400)
            {
                typeSword = "집판검";
                attack += 4;
            }
            else if (400 < userGold && userGold <= 500)
            {
                typeSword = "엑스칼리버";
                attack += 5;
            }
            else if (500 < userGold && userGold <= 600)
            {
                typeSword = "유령검";
                attack += 6;
            }
            else
            {
                typeSword = "전설의 검";
                attack += 7;
            }
            Console.Clear();

            Console.WriteLine($"캐릭터 : 멋사 검준\n보유 금액 : {userGold}\n" +
                $"무기 : {typeSword}\n{typeSword}의 공격력 : {attack}");

        }
    }
}
