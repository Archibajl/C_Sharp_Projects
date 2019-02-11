using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public class Warrior : Character1
    {
        /*Character2 w2 = new Warrior2();
        Character2 m2 = new Mage2();
        Character2 a2 = new Archer2();*/

        private int moveSpeed = 1, damagePerAttack = 20, health = 75, priority = 3, attackRange = 1;

        override public string GetMovementAttackDescription()
        {
            return $"Movement range = {moveSpeed}. Attack range = {attackRange}. Attack damage = {damagePerAttack}";
        }

        override public string GetSpecialDescription()
        {
            return $"leap up to 8 units to the spot in front of the opponent if possible, if opponent is greater than 5 units away deal 30 damage";
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
