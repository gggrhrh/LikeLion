using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study18
{
    struct Student
    {
        public string Name;
        public int Korean;
        public int English;
        public int Math;

        public void Print()
        {
            Console.WriteLine($"{Name,-5}{Korean,5}{English,5}{Math,5}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("학생의 이름을 입력하세요 : ");
                st[i].Name = Console.ReadLine();
                Console.WriteLine("국어 점수를 입력하세요 : ");
                st[i].Korean = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 점수를 입력하세요 : ");
                st[i].English = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 점수를 입력하세요 : ");
                st[i].Math = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("이름      국어 영어 수학");
            for (int i = 0; i < 3; i++)
            {
                st[i].Print();
            }

        }
    }
}
