using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            //Console.WriteLine("내년에는 " + (age + 1) + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요!", (age + 1));

            Console.Write("루인 스킬 피해를 입력하세요 : ");
            float ruinSkillDmg = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            float cardGetGage = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해를 입력하세요 : ");
            float ultraSkillDmg = float.Parse(Console.ReadLine());

            Console.Write("최대 마나를 입력하세요 : ");
            float maxMp = float.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            float isbattleGetmp = float.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량을 입력하세요 : ");
            float offbattleGetmp = float.Parse(Console.ReadLine());

            Console.Write("이동 속도를 입력하세요 : ");
            float speed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도를 입력하세요 : ");
            float ridingSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도를 입력하세요 : ");
            float transSpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소를 입력하세요 : ");
            float skillCooldown = float.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("------ 캐릭터 정보 ------\n");
            Console.WriteLine("루인 스킬 피해            : {0}%", ruinSkillDmg);
            Console.WriteLine("카드 게이지 획득량        : {0}%", cardGetGage);
            Console.WriteLine("각성기 피해               : {0}%", ultraSkillDmg);
            Console.WriteLine("최대 마나                 : {0}", maxMp);
            Console.WriteLine("전투 중 마나 회복량       : {0}", isbattleGetmp);
            Console.WriteLine("비전투 중 마나 회복량     : {0}", offbattleGetmp);
            Console.WriteLine("이동 속도                 : {0}%", speed);
            Console.WriteLine("탈 것 속도                : {0}%", ridingSpeed);
            Console.WriteLine("운반 속도                 : {0}%", transSpeed);
            Console.WriteLine("스킬 재사용 대기시간 감소 : {0}%", skillCooldown);
            



        }
    }
}
