using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit:Unit
    {
        public int XP { get; protected set; } //Accessible also in derived class

        public override float Cost { 
            get
            {
                return 5f;
            } 
        }
        public XPUnit(int mov, int health):base(mov, health)
        {
            XP = 0;
        }
        public override string ToString()
        {
            return base.ToString() + $" XP={XP}";
        }

    }
}