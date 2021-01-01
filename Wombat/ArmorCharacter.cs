namespace Wombat
{
    public class ArmorCharacter : Character
    {
        private readonly int _armor;
        
        public int Armor => _armor;
        
        public ArmorCharacter(int health, int armor) : base(health) => _armor = armor;

        protected override int CalculateDamage(int damage) => damage - _armor;
    }
}