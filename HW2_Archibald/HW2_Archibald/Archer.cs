using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public class Archer : Character1
    {
        /*Character2 w2 = new Warrior2();
        Character2 m2 = new Mage2();
        Character2 a2 = new Archer2();*/

        private  int moveSpeed = 1, damagePerAttack = 20, health = 50, priority = 2, attackRange = 6;

        override public string GetMovementAttackDescription()
        {
            return $"Movement range = {moveSpeed}. Attack range = {attackRange}. Attack damage = {damagePerAttack}";
        }

        override public string GetSpecialDescription()
        {
            return $"12 range attack, deals 10 damage";
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
