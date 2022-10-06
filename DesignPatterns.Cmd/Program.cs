using DesignPatterns.Library.AbstractFactory;



Console.ReadLine();

static void AbstractFactory()
{
    new Client(new ModernFurnitureFactory()).Main();
    new Client(new VictorianFurnitureFactory()).Main();
}