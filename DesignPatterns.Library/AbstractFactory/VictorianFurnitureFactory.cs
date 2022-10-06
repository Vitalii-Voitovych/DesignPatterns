using DesignPatterns.Library.AbstractFactory.Interfaces;
using DesignPatterns.Library.AbstractFactory.Models;

namespace DesignPatterns.Library.AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair(string model, decimal price)
        {
            return new VictorianChair()
            {
                Model = model,
                Price = price,
            };
        }

        public ITable CreateTable(string model, decimal price)
        {
            return new VictorianTable()
            {
                Model = model,
                Price = price,
            };
        }
    }
}
