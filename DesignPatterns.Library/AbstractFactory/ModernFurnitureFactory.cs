using DesignPatterns.Library.AbstractFactory.Interfaces;
using DesignPatterns.Library.AbstractFactory.Models;

namespace DesignPatterns.Library.AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair(string model, decimal price)
        {
            return new ModernChair()
            {
                Model = model,
                Price = price,
            };
        }

        public ITable CreateTable(string model, decimal price)
        {
            return new ModernTable()
            {
                Model = model,
                Price = price,
            };
        }
    }
}
