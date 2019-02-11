using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public abstract class Character2
    {        
        
        
             
        private int position = 28;

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public abstract string GetMovementAttackDescription();

        public abstract string GetSpecialDescription();
        
        public string Attack(char target)
        {            
            switch (target)
            {
                case 'w':
                    Character1 w1 = new Warrior();
                    w1.TakeDamage(DamagePerAttack);
                    break;
                case 'a' :                    
                    Character1 a1 = new Archer();
                    a1.TakeDamage(DamagePerAttack);
                    break;
                case 'm' :
                    Character1 m1 = new Mage();
                    m1.TakeDamage(DamagePerAttack);
                    break;
            }

            return $"You dealt {DamagePerAttack} damage.";
        }

        public abstract string Special(char target);

        public abstract int MoveSpeed { set; get; }

        public abstract int DamagePerAttack { set; get; }

        public abstract int Health { set; get; }

        public int Position
        {
            set { position = value; }
            get { return position; }
        }

        public abstract int Priority { set; get; }

        public abstract int AttackRange { set; get; }

    }
}
