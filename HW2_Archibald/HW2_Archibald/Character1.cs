﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW2_Archibald
{
    public abstract class Character1
    {
        Character2 w2 = new Warrior2();
        Character2 m2 = new Mage2();
        Character2 a2 = new Archer2();
        private static int position = 23;

        void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public abstract string GetSpecialDescription();

        string Attack(char target)
        {
            Character2 w2 = new Warrior2();
            Character2 m2 = new Mage2();
            Character2 a2 = new Archer2();

            switch (target)
            {
                case 'w':
                    w2.Health -= DamagePerAttack;
                break;
                case 'a' :
                    a2.Health -= DamagePerAttack;
                break;
                case 'm' :
                    m2.Health -= DamagePerAttack;
                break;
            }

            return $"You dealt {DamagePerAttack} damage.";
        }

        public abstract string Special(char target);
        
        public abstract int MoveSpeed { set; get; }

        public abstract int DamagePerAttack { set; get; }

        public abstract int Health { set; get; }     

        private int Position
        {
            set { position = value; }
            get { return position ; }
        }
        
        public abstract int Priority { set; get; }

        public abstract int AttackRange { set; get; }

    }
}


