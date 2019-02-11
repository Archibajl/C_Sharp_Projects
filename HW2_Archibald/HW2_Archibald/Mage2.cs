using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public class Mage2 : Character2
    {            

        private int moveSpeed = 1, damagePerAttack = 20, health = 50, priority = 2, attackRange = 6;

        override public string GetMovementAttackDescription()
        {
            return $"Movement range = {moveSpeed}. Attack range = {attackRange}. Attack damage = {damagePerAttack}";
        }

        override public string GetSpecialDescription()
        {
            return $"knock back the opponent 4 units, range = 3, deals 3 damage";
        }
        public override string Special(Character1 target)
        {
            string effect;
            if (((target.Position - Position) <= 3) || (Position - target.Position) <= 3)
            {
                target.TakeDamage(3);
                if(((target.Position -3) <= 0) || ((target.Position + 3) <= 50))
                {
                    if ((Position - target.Position) < 0)
                    {
                        target.Position += 3;
                    }
                    if ((target.Position-Position) <= 0)
                    {
                        target.Position -= 3;
                    }
                }
                effect = "You dealt 3 Dammage and pushed back Player 1 (4) units.";
            }
            else { effect = "Target out of range, attack failed."; }
            return effect;
        }

        override public int MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }
        public override int DamagePerAttack
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
