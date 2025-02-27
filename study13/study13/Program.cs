using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study13
{
    class Program
    {

        static void PrintHello()
        {
            Console.WriteLine("안녕하세요.");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int GetNumber()
        {
            return 42;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        //기본값을 가진 매개변수
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요 , {name}");
        }


        static void Main(string[] args)
        {
            //Greet();
            //Greet("철수");


            //PrintHello();
            //PrintMessage("반갑습니다.");

            //int num = GetNumber();
            //Console.WriteLine(num);

            //int result = Add(3, 5);
            //Console.WriteLine(result);


            //Console.WriteLine(Multiply(3,4));
            //Console.WriteLine(Multiply(1.3, 3.4));

            //int q, r;
            //Divide(10, 3, out q, out r);

            //Console.WriteLine($"몫 : {q}, 나머지 : {r}");

            int value = 5;
            Increase(ref value);

            Console.WriteLine(value);

        }

        //ref 키워드(값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }



        //out 키워드   (여러 값을 반환할때)
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;

            remainder = a % b;
        }




        //함수 오버로딩(Overloading)  타입이 다른 변수도 사용하여 같은 이름의 함수를 만들수있음

        /// <summary>
        /// 두수를 곱하는 함수
        /// </summary>
        /// <param name="a">int, double 오버로딩해놈</param>
        /// <param name="b">int, double 오버로딩해놈</param>
        /// <returns></returns>
        static int Numtiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }


    }
}
