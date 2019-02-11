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
        
        public string Attack(Character1 target)
        {
            string retstr;

            if ((AttackRange >= (target.Position - Position)) && (AttackRange >= (Position - target.Position)))
            {
                target.TakeDamage(DamagePerAttack);
                retstr = $"You dealt {DamagePerAttack} damage.";
            }
            else { retstr = "Your target is out of range try again"; }

            return retstr;
        }

        public abstract string Special(Character1 target);

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
