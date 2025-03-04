using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03_04
{

    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}");
            Console.WriteLine($"점수 : {Score}");
            Console.WriteLine($"공격력 : {Strength}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior();
            //warrior.Name = "스피어맨";
            //warrior.Score = 100;
            //warrior.Strength = 20;

            //warrior.ShowInfo();


            //Console.Write("정수를 입력하세요 : ");

            //string input = Console.ReadLine();

            //try
            //{
            //    int num = int.Parse(input);
            //    Console.WriteLine($"입력한 숫자는 {num}입니다.");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}


            //List<string> fruits = new List<string>();

            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");

            //Queue<string> task = new Queue<string>();

            //task.Enqueue("첫 번쨰 작업");
            //task.Enqueue("두 번쨰 작업");
            //task.Enqueue("세 번쨰 작업");

            //Stack<int> nums = new Stack<int>();

            //nums.Push(10);
            //nums.Push(20);
            //nums.Push(30);

            //foreach(var i in fruits)
            //{
            //    Console.WriteLine($"과일 : {i}");
            //}

            //while(task.Count > 0)
            //{
            //    Console.WriteLine($"Task : {task.Dequeue()}");
            //}

            //while (nums.Count > 0)
            //{
            //    Console.WriteLine($"숫자 : {nums.Pop()}");
            //}


            //Console.Write("아무 글자나 입력하세요 : ");

            //string str = Console.ReadLine();

            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.Replace("C#", "CSharp"));
            //Console.WriteLine(str.Length.ToString());


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNum = numbers.Where(n => n % 2 == 0);


            foreach(var i in evenNum)
            {
                Console.Write($"{i} ");
            }

            var sumNum = numbers.Sum();

            Console.WriteLine("\n숫자의 총합 : " + sumNum);



        }
    }
}
