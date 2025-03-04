using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study24
{
    class Program
    {
        static void Main(string[] args)
        {
            //값 참조 값 대입
            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}");
            //Console.WriteLine($"ReferenceType : {referenceType}");


            //박싱 언박싱
            //값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value;   //박싱
            //int unboxed = (int)boxed;   //언박싱

            //Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");


            //is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할 수 있다.

            //object obj = "Hello";

            //Console.WriteLine(obj is string);   //true     타입 확인하기
            //Console.WriteLine(obj is int);      //false

            //as 연산자로 형식변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행한다.

            //object obj = "Hello";
            //string str = obj as string; //null값이 있는 타입을 변환

            //Console.WriteLine(str is string);

            //object obj = 42;
            //var obj2 = 42;

            //if(obj is int number)
            //{
            //    Console.WriteLine($"Number : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}


            //문자열다루기

            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + ", " + name + "!";
            //Console.WriteLine(message);

            //Console.WriteLine($"Length of name : {name.Length}");   //문자열 길이
            //Console.WriteLine($"To Upper : {name.ToUpper()}");  //대문자 변환
            //Console.WriteLine($"Substring : {name.Substring(1)}");  //부분 문자열(startIndex)


            //string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Contains 'awesome' : {text.Contains("awesome")}");  //포함
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");   //시작하냐
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}"); //index위치
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")}");



            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(", ");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());

            //String 과 StringBuilder 클래서 성능차이 비교
            //반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.

            //int iterations = 10000;

            //Stopwatch sw = Stopwatch.StartNew();

            //string text = "";

            //for(int i =0; i < iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for(int i =0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}
            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");



            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류입니다.
            //예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속할수있습니다.
            //try catch

            //try 
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}

            //finally 블록은 예외 발생여부와 상관없이 항상 실행됩니다.

            //try
            //{
            //    int number = int.Parse("Not A Number");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("항상실행됩니다.");
            //}


            //throw 구문으로 직접 예외 발생시키기

            //try
            //{
            //    int age = -5;
            //    if(age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}













        }
    }
}
