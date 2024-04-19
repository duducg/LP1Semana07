namespace GameUnits
{
    public class MilitaryUnit : XPUnit // Heranca!!
    {
        public int AttackPower { get; }
        
        public override int Health { 
            get
            {
                return base.Health + XP;
            } 
            }
        public override float Cost { 
            get
            {
                return AttackPower + XP;
            } 
            }
        public void Attack(Unit u)
        {
            XP++;            
            u.Health -= AttackPower;
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
        }
        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower}";
        }
    }
}
