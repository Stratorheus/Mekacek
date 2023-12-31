namespace Mekacek
{
    internal class Matej : Human
    {
        public override void PutOnJacket(Jacket bunda)
        {
            Console.WriteLine("Nasadil si bundu jak dement obraceně");
            base.PutOnJacket(bunda);
        }
    }
}
