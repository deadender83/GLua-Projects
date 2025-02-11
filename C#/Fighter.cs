// Fighter.cs
using System;

namespace StreetFighterGame
{
    public class Fighter
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Fighter(string name)
        {
            Name = name;
            Health = 100;
        }

        public int PunchAttack()
        {
            return new Random().Next(1,7);
        }

        public int KickAttack()
        {
            return new Random().Next(5, 11);
        }

        public int SpeicalAttack1()
        {
            return new Random().Next(10, 15);
        }

        public int SpeicalAttack2()
        {
            return new Random().Next(10, 15);
        }

        public int SpeicalAttack3()
        {
            return new Random().Next(10, 15);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public bool IsDefeated()
        {
            return Health == 0;
        }

        public int Player2Attacks()
        {
            int damage = 0;

            if (PunchAttack() < 5)
            {
                damage = new Random().Next(1, 7);
            }
            else if (KickAttack() < 5)
            {
                damage = new Random().Next(5, 11);
            }

            return damage;
        }

    }
}
