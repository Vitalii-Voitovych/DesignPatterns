using DesignPatterns.Library.AbstractFactory;
using DesignPatterns.Library.FactoryMethod;


Console.ReadLine();

static void AbstractFactory()
{
    new AbstractFactoryClient(new ModernFurnitureFactory()).Main();
    new AbstractFactoryClient(new VictorianFurnitureFactory()).Main();
}

static void FactoryMethod()
{
    new FactoryMethodClient(new ChairCreator()).Main();
    new FactoryMethodClient(new TableCreator()).Main();
}