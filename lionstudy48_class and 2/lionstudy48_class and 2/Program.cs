﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy48_class_and_2
{
    class Program
    {
        class Player
        {
            public string name;
            public void Render()
            {
                Console.WriteLine("플레이어 " + name);
            }
        }

        class Wizard : Player
        {
            public string job;

            public void Render2()
            {
                Console.WriteLine("직업은 "+job+"입니다.");
            }
        }


        static void Main(string[] args)
        {
            Player p = new Player(); //객체 가져오기

            //부모
            p.name = "홍길동";
            p.Render();

            //자식
            Wizard w = new Wizard(); //객체 가져오기
            w.job = "마법사";
            w.name = "대마법사 샤우론";

            w.Render();
            w.Render2();


        }   
    }
}
