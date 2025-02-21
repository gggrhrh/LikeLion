using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            double attack = 56.7;
            string name = "자크";
            char grade = 'S';

            Console.WriteLine("캐릭터정보");
            Console.WriteLine($"hp : {hp}");
            Console.WriteLine($"att : {attack}");
            Console.WriteLine($"캐릭터이름 : {name}");
            Console.WriteLine($"등급 : {grade}");

        }
    }
}
