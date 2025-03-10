using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRpg
{
    class Monster
    {
        public string Name;
        public int Hp;
        public int Attack;


        public void SetMonster(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
        }

        public void Render()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"몬스터 이름 : {Name}");
            Console.WriteLine($"체력 : {Hp}    공격력 : {Attack}");
        }

    }
}
