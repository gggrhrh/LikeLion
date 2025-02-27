﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study17
{
    class Program
    {
        //C# 구조체
        // 클래스와 비슷하지만 , 값 타입(Value Type)이며 가볍고 빠름
        //
        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용하려고 하는 키워드
            public int X;
            public int Y;

            //생성자 정의 처음생성할때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Print()
            {
                Console.WriteLine($"좌표 : {X}, {Y}");
            }
        }
         
        //구저체는 클래스와 다르게 new 없이 사용 가능

        //struct에 생성자 사용 가능
        //모든 필드를 초기화해줘야함
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 16);    //생성자 함수
            p1.Print();


            Point p; //구조체 선언 (초기화 필요)
            p.X = 10;
            p.Y = 20;
            
            p.Print();
         

        }
    }
}
