using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int integerNum = 10;
            //float floatNum = 3.14f;
            //double doubleNum = 3.141592;

            //Console.Write(integerNum); Console.Write(floatNum); Console.Write(doubleNum);

            //int intValue = -100;
            //long longValue = 1234567890L;

            //Console.WriteLine(intValue);
            //Console.WriteLine(longValue);


            //sbyte signedByte = -50;
            //short signedShort = -32000;
            //int signedInt = -2000000000;

            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            //byte unsignedByte = 255;          //1바이트
            //ushort unsignedShort = 65000;     //2바이트
            //uint unsignedInt = 4000000000;    //4바이트

            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsignedInt);

            //float singlePrecision = 3.14f;      //4바이트
            //double doublePrecision = 3.1415926535;  //8바이트
            //decimal highPrecision = 3.1415926536897932384626m;  //16바이트

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //int integerValue = 100;     //4바이트
            //long longValue = 100L;      //8바이트
            //float floatValue = 3.14f;   //4바이트
            //double doubleValue = 3.14;  //8바이트
            //decimal decimalValue = 3.14m;   //16바이트

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);


            //char letter = 'A';    //2바이트
            //char symbol = '#';
            //char number = '9';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //string greeting = "Hello World";
            //string name = "Alice";

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            //Console.WriteLine(greeting + " " + name);

            //bool형식 : 참 = 1, 거짓 = 0
            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //const double Pi = 3.141592;
            //const int MaxScore = 100;

            //Console.WriteLine(Pi);
            //Console.WriteLine(MaxScore);
            ////Pi = 3.14;


            ////닷넷 형식
            //System.Int32 number = 999999999;
            //System.String text = "Hello";
            //System.Boolean flag = true;

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);


            int number = 123;

            string numberAsString = number.ToString();

            bool flag = true;

            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);


        }
    }
}
