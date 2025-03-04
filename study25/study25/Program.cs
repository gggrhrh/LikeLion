using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study25
{
    //제네릭 사용하기 (Generics)
    //<T> 제네릭 클래스를 사용하면 특정 타입에
    //종속되지 않는 범용 클래스를 만들수 있습니다.

    class Cup<T>
    {
        public T Content { get; set; }
    }

    class SimpleCollection: IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach(var item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

    class Program
    {


        static void Main(string[] args)
        {


            //var collection = new SimpleCollection();

            //foreach(var i in collection)
            //{
            //    Console.WriteLine(i);
            //}


            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;


            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}

            //string str = null;
            //if(str == null)
            //{
            //    Console.WriteLine("str is null");
            //}

            //int? nullableInt = null;

            //Console.WriteLine(nullableInt.HasValue? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //null 값을 다루는 연산자 소개하기 ?? , ?. 연산자
            //?? 연산자를 사용해 null인 경우 대체값을 제공하고 , ?.은 null 안전 접근을 합니다.

            //string str = null;

            //Console.WriteLine(str ?? "DefalutValue");   //null 이면 DefalutValue출력

            //str = "Hello";

            //Console.WriteLine(str?.Length);


            //LINQ는 확장메서드 형태로 제공된다.
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수 있습니다.

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach(var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}







            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString : {cupOfString.Content}");
            //Console.WriteLine($"CupOfInt : {cupOfInt.Content}");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");


            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //IEnumerator
            //C#컬렉션 순회 반복할수있는 인터페이스

            //    public interface IEnumerator
            //{
            //    bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환)
            //    object Current { get; } // 현재 요소 반환
            //    void Reset(); // 처음 위치로 리셋
            //}

            //ArrayList list = new ArrayList { "Apple", "Bannan", "Cherry" };

            //IEnumerator enumerator = list.GetEnumerator();  //열거자 가져오기

            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}






            ////배열과 컬렉션
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            //배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            //List<string> names = new List<string>{ "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");
            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;
            //list.Remove(3);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //Stack First In Finally Out

            //Stack stack = new Stack();  //맨앞에 추가

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while(stack.Count>0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}



            ////Queue First IN First Out
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("Hello");
            //arrayList.Add(3.14);

            //Console.WriteLine("ArrayList 요소 : ");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Remove(1);
            //Console.WriteLine("\nArrayList 요소 제거 후 : ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //Hashtable 클래스
            //키 - 값 쌍을 저장하는 컬렉션이다.
            //키를 이용하여 값을 빠르게 검색할 수 있다.


            //Hashtable hashtable = new Hashtable();

            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소 :");

            //foreach(DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}

            ////특정 키의 값 가져오기
            //Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");

            ////요소제거
            //hashtable.Remove("Bob");

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}










        }
    }
}
