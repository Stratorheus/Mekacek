namespace Mekacek
{
    internal class Jacket
    {
        public string Color;
        public bool Zipper;

        public void ZipUpYourJacket( )
        {
            if ( Zipper )
            {
                Console.WriteLine("Zipeček se ti zapíná");
            }
            else
            {
                Console.WriteLine("Knofličky si si dal");
            }

        }

    }
}
