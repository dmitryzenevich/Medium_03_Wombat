using System;

namespace Wombat
{
    public abstract class Character
    {
        private int _health;

        public int Health
        {
            get => _health;
            protected set => _health = value;
        }

        protected Character(int health) => _health = health;

        public void TakeDamage(int damage)
        {
            Health -= CalculateDamage(damage);

            if (Health <= 0)
                Console.WriteLine("I died");
        }

        protected abstract int CalculateDamage(int damage);
    }
}