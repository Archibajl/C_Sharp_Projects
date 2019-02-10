﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    class Warrior : Character1
    {
        private static int moveSpeed = 1, damagePerAttack = 20, health = 75, priority = 3, attackRange = 1;

        override public string GetSpecialDescription()
        {
            return $"Movement range = {moveSpeed}. Attack range = {attackRange}. Attack damage = {damagePerAttack}";
        }
        override public string Special(char target)
        {
            return $"";
        }

        override public int MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }

        override public int DamagePerAttack
        {
            get { return damagePerAttack; }
            set { damagePerAttack = value; }
        }

        override public int Health
        {
            get { return health; }
            set { health = value; }
        }

        override public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        override public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
    }
}
