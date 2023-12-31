namespace Mekacek
{
    internal class Martin : Human
    {
        public override void GetInTheCar(Car renolt)
        {
            renolt.SetDriver(this);
            Console.WriteLine($"{Name} si sedl na místo řidiče");
        }
    }
}
