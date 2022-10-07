using DesignPatterns.Library.AbstractFactory;



Console.ReadLine();

static void AbstractFactory()
{
    new AbstractFactoryClient(new ModernFurnitureFactory()).Main();
    new AbstractFactoryClient(new VictorianFurnitureFactory()).Main();
}