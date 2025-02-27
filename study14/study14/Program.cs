using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는것을 방지하기위해 사용된다.
namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요! MyNamespace의 MyClass입니다.");
        }
    }
}





namespace study14
{
    class Program
    {
        ////params 키워드
        //static int Sum(params int[] numbers)
        //{
        //    int total = 0;

        //    foreach(int num in numbers)
        //    {
        //        total += num;
        //    }

        //    return total;

        //}


        ////재귀함수(자기자신을 호출)
        //static int Factorial(int n)
        //{
        //    if (n <= 1)
        //        return 1;

        //    return n * Factorial(n - 1);
        //}



        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(5));

            dev1.MyClass.SayHello();

        }
    }
}
