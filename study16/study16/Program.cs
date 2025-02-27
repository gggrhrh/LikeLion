using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study16
{
    class Program
    {

        //열거형이란?
        //Enumeration enum
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미있는 값으로 표현가능
        //기본적으로 첫 번째 값은 0부터 시작 1씩 증가

        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }
       
        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapontype)
        {
            if (weapontype == WeaponType.Sword)
                Console.WriteLine("검을 선택했습니다.");
            else if (weapontype == WeaponType.Bow)
                Console.WriteLine("활을 선택했습니다.");
            else if (weapontype == WeaponType.Staff)
                Console.WriteLine("지팡이를 선택했습니다.");
        }

        static void Main(string[] args)
        {
            ChooseWeapon(WeaponType.Bow);



            //Math클래스
            //수학적 계산
            //Console.WriteLine($"Pi : {Math.PI}");   //파이
            //Console.WriteLine($"Square root of 25 : {Math.Sqrt(25)}");  //제곱근
            //Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");   //거듭제곱
            //Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}"); //반올림

            //DayOfWeek today = DayOfWeek.Wednesday;

            //Console.WriteLine(today);
            //Console.WriteLine((int)today);

            //StatusCode status = StatusCode.NotFound;
            //Console.WriteLine(status);
            //Console.WriteLine((int)status);

        }
    }
}
