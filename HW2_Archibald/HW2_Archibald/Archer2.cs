using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public class Archer2 : Character2
    {
       /* Character1 w1 = new Warrior();
        Character1 m1 = new Mage();
        Character1 a1 = new Archer();*/

        private int moveSpeed = 1, damagePerAttack = 20, health = 50, priority = 2, attackRange = 6;

        override public string GetMovementAttackDescription()
        {
            return $"Movement range = {moveSpeed}. Attack range = {attackRange}. Attack damage = {damagePerAttack}";
        }

        override public string GetSpecialDescription()
        {
            return $"12 range attack, deals 10 damage";
        }
        
        override public string Special(Character1 target)
        {
            string effect;
            if(((target.Position-Position) <= 12)||(Position-target.Position) <= 12) {
                target.TakeDamage(10);
                effect = "You dealt 10 Dammage";
            }
            else { effect = "Target out of range, attack failed."; }
            return effect;
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
