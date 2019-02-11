using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public abstract class Character1
    {       
        
        private int position = 23;

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
                    Character2 w2 = new Warrior2();
                    if ((AttackRange >= (w2.Position - Position)) && (AttackRange >= (Position - w2.Position)))
                    {                        
                        w2.TakeDamage(DamagePerAttack);
                    }
                    break;
                case 'a':
                    Character2 a2 = new Archer2();
                    if ((AttackRange >= (a2.Position - Position)) && (AttackRange >= (Position - a2.Position)))
                    {
                        a2.TakeDamage(DamagePerAttack);
                        return $"You dealt {DamagePerAttack} damage.";
                    }
                    break;
                case 'm':
                    Character2 m2 = new Mage2();
                    if ((AttackRange >= (m2.Position-Position))&&(AttackRange >= (Position-m2.Position)))
                    {
                        m2.TakeDamage(DamagePerAttack);
                    }
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
            get { return position ; }
        }
        
        public abstract int Priority { set; get; }

        public abstract int AttackRange { set; get; }

    }
}


