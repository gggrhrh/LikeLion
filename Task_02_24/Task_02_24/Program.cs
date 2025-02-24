using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ 문제 1 ------");

            Console.WriteLine("첫번째 정수를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 정수를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("세번째 정수를 입력하세요 : ");
            int num3 = int.Parse(Console.ReadLine());

            int X = num1;

            if (X < num2)
            {
                X = num2;
            }

            if (X < num3)
            {
                X = num3;
            }

            Console.WriteLine($"{num1}, {num2}, {num3} 중 가장 큰 값은 {X}입니다.");

            Console.WriteLine("\n\n------ 문제 2 ------");
            Console.WriteLine("자신의 점수를 입력하세요 : ");
            int score = int.Parse(Console.ReadLine());
            char grade;
            if (score >= 90)
            {
                grade = 'A';
            }
            else if (80 <= score && score < 90)
            {
                grade = 'B';
            }
            else if (70 <= score && score < 80)
            {
                grade = 'C';
            }
            else if (60 <= score && score < 70)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"당신은 {grade} 학점입니다.");


            Console.WriteLine("\n\n------ 문제 3 ------");
            Console.WriteLine("첫번째 숫자를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력하세요 : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("사칙연산 중 하나를 입력하세요 : ");
            string symbol = Console.ReadLine();

            int result;
            if (symbol == "+")
            {
                result = a + b;
            }
            else if (symbol == "-")
            {
                result = a - b;
            }
            else if (symbol == "/")
            {
                result = a / b;
            }
            else if (symbol == "*")
            {
                result = a * b;
            }
            else
            {
                result = 0;
                Console.WriteLine("사칙연산을 잘못입력하셨습니다.");
            }

            Console.WriteLine($"{a} {symbol} {b} = {result}");


        }
    }
}
