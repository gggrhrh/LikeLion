using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study12
{
    class Program
    {

        //1단계함수
        //반환형 함수이름 (매개변수)
        //{
        //}
        //1단계 기본형
        static void Loading()
        {

            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }


        //2단계
        //입력

        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }


        //3단계
        //출력

        static int BaseAttack()
        {
            int attack = 10;

            return attack;
        }


        static int Add(int a, int b)
        {
            int add = a + b;
            return add;
        }

        static void Main(string[] args)
        {
            //int Attack = 0;
            //int bAttack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            ////기본공격력
            //bAttack =  BaseAttack();

            //AttackFunction(Attack + bAttack);

            //Console.WriteLine($"기본공격력 : {bAttack}");

            int result = Add(10, 20);

            Console.WriteLine($"10 + 20 = {result}");
        }
    }
}
