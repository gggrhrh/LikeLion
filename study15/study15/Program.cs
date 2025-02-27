﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study15
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        // |
        // |
        // v
        //화살표 함수
        static int AddArrow(int a, int b) => a + b;

        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요.");
        }
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");


        static void Main(string[] args)
        {
            //C#화살표 함수
            //C#에서 화살표 함수 => 람다 표현식 이라고도 하며
            //간결한 방식으로 함수를 정의할 수 있습니다.
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));

            PrintMessage();
            PrintMessageArrow();

        }
    }
}
