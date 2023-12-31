namespace Mekacek
{
    internal class Car
    {
        public string Brand;
        public string Color;
        private Human Driver;
        private List<Human> Passenger = new List<Human>();

        public void GoToLocation(string location)
        {
            bool isDriverPresent = EnsureDriverPresence( );
            if ( !isDriverPresent )
            {
                Console.WriteLine("Auto nemuže nikam ject bez řidiča");
                return;
            }

            Console.WriteLine($"Auto jede na lokaci ({location})");
            for ( int i = 0 ; i < 10 ; i++ )
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine( );
            Console.WriteLine($"Auto dojelo na lokaci ({location})");
            WritePassangers( );
        }

        private bool EnsureDriverPresence( )
        {
            if ( Driver == null )
            {
                Console.WriteLine("Auto nemá řidiče");
                return false;
            }
            Console.WriteLine($"Auto má řidiče:{Driver.Name}");
            return true;
        }

        public void AddPassanger(Human passenger)
        {
            Passenger.Add(passenger);
            Console.WriteLine($"Pasažér byl přidan: {passenger.Name}");
        }

        public void SetDriver(Martin driver)
        {
            Driver = driver;
            Console.WriteLine($"Řidič byl nastaven: {driver.Name}");
        }

        private void WritePassangers( )
        {
            Console.WriteLine($"Řidič: {Driver.Name}");

            foreach ( Human passenger in Passenger )
            {
                Console.WriteLine($"Cestující {passenger.Name}");

            }



        }
    }
}
