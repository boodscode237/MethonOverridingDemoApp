namespace MethonOverridingDemo
{
    public class Tesla : Car
    {
        public override void SetClock()
        {
            System.Console.WriteLine("It sets itself");
        }
        public override void StartCar()
        {
            System.Console.WriteLine("Think about your destination");
        }
    }
}
