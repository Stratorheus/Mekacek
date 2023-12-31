namespace Mekacek
{
    internal abstract class Human
    {
        public string Name;
        public int IQ;
        public virtual void PutOnJacket(Jacket bunda)
        {
            Console.WriteLine($"{Name} si zapíná bundu");
            bunda.ZipUpYourJacket( );
            Console.WriteLine($"Barva bundy je {bunda.Color}");
        }

        public virtual void GetInTheCar(Car renolt)
        {
            renolt.AddPassanger(this);
            Console.WriteLine($"{Name} nastoupil do auta");
        }


    }
}

