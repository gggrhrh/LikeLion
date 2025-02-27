using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("------ 1번 문제 ------");
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //Console.WriteLine("------ 2번 문제 ------");
            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("정수를 입력하세요 : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"정수의 총합 : {sum}");


            //Console.WriteLine("------ 3번 문제 ------");
            //int[] numbers = { 3, 8, 15, 6, 2 };
            //int maxNum = 0;

            //for(int i= 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNum)
            //    {
            //        maxNum = numbers[i];
            //    }
            //}
            //Console.WriteLine($"최댓값 : {maxNum}");


            //Console.WriteLine("------ 4번 문제 ------");

            //for (int i = 1; i < 11; i++)
            //    Console.Write(i + " ");


            //Console.WriteLine("------ 5번 문제 ------");

            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    i++;
            //}


            //Console.WriteLine("------ 6번 문제 ------");
            //int[] nums = { 1, 2, 3, 4, 5 };

            //foreach (int i in nums)
            //    Console.Write(i + " ");


            //Console.WriteLine("------ 7번 문제 ------");

            //Console.Write("첫 번째 정수를 입력하세요 : ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("두 번째 정수를 입력하세요 : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{a} + {b} = {Sum(a, b)}");


            //Console.WriteLine("------ 8번 문제 ------");

            //Console.Write("문자열을 입력하세요 : ");
            //string input = Console.ReadLine();
            //Console.WriteLine(Length(input));


            Console.WriteLine("------ 9번 문제 ------");

            Console.Write("첫 번째 정수를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하세요 : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수를 입력하세요 : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}, {b}, {c}중 가장 큰 수는 {FindMaxNum(a, b, c)}입니다.");


        }//static void Main(string[] args)

        static int FindMaxNum(int a, int b, int c)
        {
            int maxnum = 0;

            if (a > maxnum)
                maxnum = a;
            if (b > maxnum)
                maxnum = b;
            if (c > maxnum)
                maxnum = c;

            return maxnum;
        }

        static int Length(string str)
        {
            return str.Length;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

    }
}
