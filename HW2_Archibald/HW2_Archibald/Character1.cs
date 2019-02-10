using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW2_Archibald
{
    public abstract class Character1
    {
        private static int position = 23;

        void TakeDamage(int amount)
        {

        }

        public abstract string GetSpecialDescription();

        string Attack(Character1 target)
        {

            return $"You dealt {DamagePerAttack} damage.";
        }

        public abstract string Special(Character1 target);
        
        public abstract int MoveSpeed { set; get; }

        public abstract int DamagePerAttack { set; get; }

        public abstract int Health { set; get; }     

        private int Position
        {
            set { position = value; }
            get { return position ; }
        }
        
        public abstract int Priority { set; get; }

        public abstract int AttackRange { set; get; }

    }
}


