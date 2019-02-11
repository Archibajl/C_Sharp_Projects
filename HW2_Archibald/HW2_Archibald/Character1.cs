using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    public abstract class Character1
    {
        Character2[] character2 = {
            new Warrior2(),
            new Archer2(),
            new Mage2()
            };

        private int position = 23;

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public abstract string GetMovementAttackDescription();

        public abstract string GetSpecialDescription();

        public string Attack(int target)
        {
            string retstr;

            if ((AttackRange >= (character2[target].Position - Position)) && (AttackRange >= (Position - character2[target].Position)))
            {
                character2[target].TakeDamage(DamagePerAttack);
                retstr = $"You dealt {DamagePerAttack} damage.";
            }
            else { retstr = "Your target is out of range try again"; }

            return retstr;
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


