using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            //Test class instance
            MilitaryUnit mu = new MilitaryUnit(1,10,2);
            mu.Move();
            Console.WriteLine(mu.Health);
            Console.WriteLine(mu.Cost);
            
            SettlerUnit su = new SettlerUnit();
            su.Move();
            Console.WriteLine(su.Health);
            Console.WriteLine(su.Cost);

            


        }
    }
}
