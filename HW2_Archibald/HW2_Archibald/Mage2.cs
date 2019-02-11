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
        public override string Special(char target)
        {
            switch (target)
            {
                case 'w':
                    Character1 w1 = new Warrior();
                    w1.TakeDamage(DamagePerAttack);
                    break;
                case 'a':
                    Character1 a1 = new Archer();                    
                    a1.TakeDamage(DamagePerAttack);
                    break;
                case 'm':
                    Character1 m1 = new Mage();
                    m1.TakeDamage(DamagePerAttack);
                    break;
            }
            return $"";
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
