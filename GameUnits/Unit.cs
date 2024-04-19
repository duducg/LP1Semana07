using System;

namespace GameUnits
{
    //class is now abstract because it has at least 1 abstract member
    public abstract class Unit 
    {
        private int movement;
        public virtual int Health { get; set; } //virtual can be changed
        public abstract float Cost { get; } //cost is now forced to defined in
        //derived class

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public void Move()
        {
            Console.WriteLine(movement);
        }
    }
}
