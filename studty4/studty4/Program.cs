using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace studty4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting;
            //greeting = "Hello, World!";

            //Console.WriteLine(greeting);

            //int score = 100;
            //double temperature = 36.5;
            //string city = "Seoul";

            //Console.WriteLine(score);
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);

            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.1415926535;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi : " + Pi);
            //Console.WriteLine("Max Score : " + MaxScore);

            int attack = 16755, maxHP = 78103, cri = 36, special = 1017, overpower = 41
                , speed = 611, patience = 22, skill = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 : " + attack);
            Console.WriteLine("최대 생명력 : " + maxHP);
            Console.WriteLine("전투 특성");
            Console.WriteLine("치명 : " + cri);
            Console.WriteLine("특화 : " + special);
            Console.WriteLine("제압 : " + overpower);
            Console.WriteLine("신속 : " + speed);
            Console.WriteLine("인내 : " + patience);
            Console.WriteLine("숙련 : " + skill);




        }
    }
}
