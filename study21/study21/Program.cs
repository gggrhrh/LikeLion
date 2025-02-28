using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study21
{
    class Program
    {

        //class Person
        //{
        //    private string name;

        //    public void SetName(string newName)
        //    {
        //        name = newName;
        //    }

        //    public string GetName()
        //    {
        //        return name;
        //    }
        //}

        //class Person
        //{
        //    private string name;

        //    public string Name
        //    {
        //        get { return name;} //Getter
        //        set { name = value; }   //Setter
        //    }
        //}

        //class Person
        //{
        //    private int count = 100;

        //    public string Name { get; set; }
        //    public int Count
        //    {
        //        get { return count; }   //읽기만 가능
        //    }

        //    public float Balance { get; private set; }

        //    public void AddBal()
        //    {
        //        Balance += 100;
        //    }
        //}

        class Marin
        {
            public string Name { get; private set; } = "마린";
            public int Mineral { get; private set; } = 50;


        }


        static void Main(string[] args)
        {
            //C# get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을

            //Person p = new Person();

            //p.Name = "홍길동";
            //p.AddBal();
            //Console.WriteLine("이름 : " + p.Name + " Count : "+ p.Count +" Balance : " + p.Balance);

            Marin marin = new Marin();
            Console.WriteLine($"이름 : {marin.Name} | 미네랄 : {marin.Mineral}");

        }
    }
}
