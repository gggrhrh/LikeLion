using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace study20
{
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }

        public Marin(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

    }

    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        public SCV(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    class Berrack
    {
        public string Name;
        public int Mineral;

        public Berrack()
        {
            Name = "배럭";
            Mineral = 150;
        }

        public Berrack(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }

    }


    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }
    }

    //Game
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral} | 가스 : {gas} | 인구수 : {charCount}");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();

            Marin marin = new Marin("불꽃테란", 100);
            SCV scv = new SCV("열받은SCV", 70);
            Berrack berrack = new Berrack();
            //클래스의 배열
            Mineral[] mineral = new Mineral[7];
            //클래스에 입력
            for (int i = 0; i < 7; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }

            marin.ShowInfo();

            scv.ShowInfo();

            berrack.ShowInfo();
        }
    }
}
