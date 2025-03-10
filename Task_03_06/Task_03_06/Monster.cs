using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_06
{
    class Monster
    {
        public string Name;
        public int Hp;
        public int Attack;
        public int Defence;
        Random rand = new Random();

        public void TakeDamage(int damage)
        {
            int attack = damage - rand.Next(1, Defence + 1);
            if (attack <= 0)
                attack = 1;
            Hp -= attack;
        }

        public void Render()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"몬스터 이름 : {Name}    체력 : {Hp}");
            Console.WriteLine($"공격력 : {Attack}       방어력 : {Defence}");
        }

    }
}
