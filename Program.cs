// See https://aka.ms/new-console-template for more information

using Mekacek;

Matej matej = new Matej();
matej.IQ = 5000;
matej.Name = "Marek";

Martin martin = new Martin();
martin.IQ = matej.IQ * 10;
martin.Name = "MartinNejvicChytrejClovekNaPlanete";

Car car = new Car();
car.Brand = "Felicia";
car.Color = "Šeda";

Jacket martinJacket = new Jacket();
martinJacket.Color = "Negrová";
martinJacket.Zipper = false;

Jacket matejJacket = new Jacket();
matejJacket.Color = "Modra";
matejJacket.Zipper = true;

matej.PutOnJacket(matejJacket);
martin.PutOnJacket(martinJacket);
matej.GetInTheCar(car);
car.GoToLocation("HOVNA");
martin.GetInTheCar(car);
car.GoToLocation("Mekaček");
Console.ReadLine( );
