using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study28
{

    //메서드 오버라이딩(Overriding)
    //부모 클래스의 메서드를 자식 클래스에서 재 정의(override)하여 다른 동작을 수행할수있습니다

    public class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "일반동물";
            myAnimal.Speak();

            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Speak();


        }
    }
}
