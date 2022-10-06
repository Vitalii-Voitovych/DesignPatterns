using DesignPatterns.Library.AbstractFactory.Interfaces;

namespace DesignPatterns.Library.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair(string model, decimal price);
        ITable CreateTable(string model, decimal price);
    }
}
