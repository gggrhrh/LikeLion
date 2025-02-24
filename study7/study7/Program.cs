using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 5;
            //bool flag = true;


            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag);  //논리 부정 : false  

            //int num = 10;
            //int result = ~num;   //모든 비트 반전 : 1111 0101 결과 


            //Console.WriteLine("원래 값 : " + num);
            //Console.WriteLine("~ 연산자 적용 후: " + result);

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3;  //평균

            //Console.WriteLine("총점 : " + sum);
            //Console.WriteLine("평균 : " + average);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName); //출력

            //int a = 10;
            //a += 5;  // a  = a + 5;

            //Console.WriteLine(a);

            //int a = 10;
            //a += 5;  // a  = a + 5;
            //Console.WriteLine(a);
            //a -= 5;  // a  = a - 5;
            //Console.WriteLine(a);
            //a *= 5;  // a  = a * 5;
            //Console.WriteLine(a);
            //a /= 5;  // a  = a / 5;
            //Console.WriteLine(a);
            //a %= 5;  // a  = a % 5;
            //Console.WriteLine(a);

            Console.WriteLine("------ 문제 1 ------");

            Console.WriteLine("국어 점수를 입력하세요 : ");
            int iKorean = Int32.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수를 입력하세요 : ");
            int iEnglish = Int32.Parse(Console.ReadLine());
            Console.WriteLine("수학 점수를 입력하세요 : ");
            int iMath = Int32.Parse(Console.ReadLine());

            int iTotal = 0;
            iTotal = iKorean + iEnglish + iMath;
            float fAvg = 0.0f;
            fAvg = (float)iTotal / 3;

            Console.WriteLine($"과목 총 합 점수 : {iTotal}");
            Console.WriteLine($"과목 평균 점수 : {fAvg.ToString("F2")}");

            Console.WriteLine("\n\n------ 문제 2 ------");
            Console.WriteLine("정수를 입력하세요 : ");
            int iNum = Int32.Parse(Console.ReadLine());
            int bitNum = 0;
            bitNum = ~iNum;
            Console.WriteLine($"비트 반전 연산자 활용 \n입력한 숫자 : {iNum}");
            Console.WriteLine($"비트 반전 숫자 : {bitNum}");



        }
    }
}
