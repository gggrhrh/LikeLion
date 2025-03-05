using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_05LOL
{

    public class Champion
    {
        public string Name = "";
        public int HP = 0;
        public int MP = 0;
        public int Attack = 0;
        public string ChampionSkill = "";


        public Champion()
        {
            Name = "갈리오";
            HP = 600;
            MP = 410;
            Attack = 59;
            ChampionSkill = "전장의 돌풍";

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"현재상태 | 이름 : {Name}  체력 : {HP}  마나 : {MP}  공격력 : {Attack}");
        }

        public virtual void UseSkill(Champion champion)
        {
            Console.WriteLine($"{champion.Name}에게 {ChampionSkill}을 사용합니다. ");
        }


    }

    class Blitzcrank : Champion
    {
        public Blitzcrank()
        {
            Name = "블리츠크랭크";
            HP = 600;
            MP = 267;
            Attack = 60;
            ChampionSkill = "로켓 손";

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

        public override void UseSkill(Champion champion)
        {
            Console.WriteLine($"{ChampionSkill}을 사용합니다.{champion.Name}을 끌어옵니다.");
        }

    }

    class Jayce : Champion
    {
        public Jayce()
        {
            Name = "제이스";
            HP = 590;
            MP = 375;
            Attack = 59;
            ChampionSkill = "전격 폭발";
        }

        public override void UseSkill(Champion champion)
        {
            base.UseSkill(champion);
        }

    }

    class Sylas : Champion
    {
        public Sylas()
        {
            Name = "사일러스";
            HP = 600;
            MP = 400;
            Attack = 61;
            ChampionSkill = "국왕시해자";
        }
        public override void UseSkill(Champion champion)
        {
            Console.WriteLine($"{ChampionSkill}을 사용해 체력을 회복합니다.");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champions = new List<Champion>();
            champions.Add(new Blitzcrank());
            champions.Add(new Jayce());
            champions.Add(new Champion());
            champions.Add(new Sylas());

            Random rand = new Random();
            foreach (var champ in champions)
            {
                champ.ShowInfo();
                champ.UseSkill(champions[rand.Next(0, 4)]);
            }

        }
    }
}
