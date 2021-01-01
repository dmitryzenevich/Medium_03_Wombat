namespace Wombat
{
    public class AgilityCharacter : Character
    {
        private readonly int _agility;

        public int Agility => _agility;

        public AgilityCharacter(int health, int agility) : base(health) => _agility = agility;
        protected override int CalculateDamage(int damage) => damage / _agility;
    }
}