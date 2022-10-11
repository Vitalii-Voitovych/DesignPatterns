using DesignPatterns.Library.AbstractFactory;
using DesignPatterns.Library.Builder;
using DesignPatterns.Library.FactoryMethod;

Builder();

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

static void Builder()
{
    new BuilderClient().Main();
}