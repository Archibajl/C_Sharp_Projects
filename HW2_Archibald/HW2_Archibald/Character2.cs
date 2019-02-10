using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Archibald
{
    abstract class Character2
    {
        Character1 w1 = new Warrior();
        Character1 m1 = new Mage();
        Character1 a1 = new Archer();        

        private static int position = 28;

        void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public abstract string GetSpecialDescription();
        
        string Attack(char target)
        {            
            switch (target)
            {
                case 'w':
                    w1.Health -=  DamagePerAttack;
                    break;
                case 'a' :
                    a1.Health -= DamagePerAttack;
                    break;
                case 'm' :
                    m1.Health -= DamagePerAttack;
                    break;
            }

            return $"You dealt {DamagePerAttack} damage.";
        }

        public abstract string Special(char target);

        public abstract int MoveSpeed { set; get; }

        public abstract int DamagePerAttack { set; get; }

        public abstract int Health { set; get; }

        private int Position
        {
            set { position = value; }
            get { return position; }
        }

        public abstract int Priority { set; get; }

        public abstract int AttackRange { set; get; }

    }
}
