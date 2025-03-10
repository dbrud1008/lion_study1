using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy73_textRPG_test
{
    public class Player
    {
        public INFO info;

        public void SetDamage(int attack) //데미지 받음
        {
            info.hp -= attack;
        }

        public INFO GetInfo()
        {
            return info;
        }

        public void SetHp(int hp)
        {

        }

        public void Job()
        {
            info = new INFO();

            Console.WriteLine("=====직업을 선택하세요.=====");
            Console.WriteLine("1. 기사   2. 마법사   3. 도둑");

            int input = 0;

            switch(input)
            {
                //이름, 공격력, hp 정의
                case 1:
                    info.name = "기사";
                    info.attack = 10;
                    info.hp = 100;
                    break;
                case 2:
                    info.name = "마법사";
                    info.attack = 15;
                    info.hp = 150;
                    break;
                case 3:
                    info.name = "도둑";
                    info.attack = 22;
                    info.hp = 140;
                    break;
            }
        }


        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("직업 이름: " + info.name);
            Console.WriteLine("공격력: " + info.attack, "체력: " + info.hp);
        }


        public Player() {}

        ~Player() { }
    }
}
