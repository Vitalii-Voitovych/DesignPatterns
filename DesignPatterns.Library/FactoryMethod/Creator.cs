using DesignPatterns.Library.FactoryMethod.Interfaces;

namespace DesignPatterns.Library.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IFurniture CreateFurniture(string model, decimal price);
    }
}
