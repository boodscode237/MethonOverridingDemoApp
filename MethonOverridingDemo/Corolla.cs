using System;

namespace MethonOverridingDemo
{
    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Fiddle with the corolla clock");
        }
    }
}
