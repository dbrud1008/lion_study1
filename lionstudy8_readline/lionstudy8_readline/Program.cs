using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy8_readline
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로 부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님");


            //문자열을 정수로 변환
            //Console.WriteLine("나이를 입력하세요: ");
            //string input = Console.ReadLine(); //사용자ㅏ로 부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!"); //변환된 값 사용
            //Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);

            float skill = 0.0f;
            float Card = 0.0f;
            float MaxSkill = 0.0f;
            int MP = 0;
            int FMpHeal = 0;
            int NFMpHeal = 0;
            float Speed = 0.0f;
            float hicleSpeed = 0.0f;
            float CarrySpeed = 0.0f;
            float Cooldown = 0.0f;

            Console.WriteLine("루인 스킬 피해량을 입력하세요 : ");
            skill = float.Parse(Console.ReadLine());

            Console.WriteLine("카드 게이지 획득량을 입력하세요 : ");
            Card = float.Parse(Console.ReadLine());

            Console.WriteLine("각성기 피해량을 입력하세요 : ");
            MaxSkill = float.Parse(Console.ReadLine());

            Console.WriteLine("최대 마나 입력하세요 : ");
            MP = int.Parse(Console.ReadLine());

            Console.WriteLine("전투 중 마나 회복량 : ");
            FMpHeal = int.Parse(Console.ReadLine());

            Console.WriteLine("비전투 중 마나 회복량 : ");
            NFMpHeal = int.Parse(Console.ReadLine());

            Console.WriteLine("이동 속도 : ");
            Speed = float.Parse(Console.ReadLine());

            Console.WriteLine("탈 것 속도 : ");
            hicleSpeed = float.Parse(Console.ReadLine());

            Console.WriteLine("운반 속도 : ");
            CarrySpeed = float.Parse(Console.ReadLine());

            Console.WriteLine("스킬 재사용 대기시간 감소 : ");
            Cooldown = float.Parse(Console.ReadLine());

            Console.WriteLine("활동");
            Console.WriteLine($"루인 스킬 피해: {skill} % ");
            Console.WriteLine($"카드 게이지 획득량: {Card} % ");
            Console.WriteLine($"각성기 피해 : {MaxSkill} % ");
            Console.WriteLine($"최대 마나 : {MP} ");
            Console.WriteLine($"전투 중 마나 회복량 : {FMpHeal} ");
            Console.WriteLine($"비전투 중 마나 회복량 : {NFMpHeal} ");
            Console.WriteLine($"이동 속도 : {Speed} % ");
            Console.WriteLine($"탈 것 속도 : {hicleSpeed} % ");
            Console.WriteLine($"운반 속도 : {CarrySpeed} % ");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {Cooldown} % ");



        }
    }
}
