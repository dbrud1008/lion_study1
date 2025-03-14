﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lionstudy64_Parent_class_test
{
    class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name, 100, 15, 10) //(이름, 체력, 공격력, 방어력)
        {

        }
        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 기본 공격을 시도합니다!");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 필살기를 시전합니다.");
            target.TakeDamage(Attack * 2);

        }
    }
}
