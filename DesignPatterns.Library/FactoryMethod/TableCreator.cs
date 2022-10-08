using DesignPatterns.Library.FactoryMethod.Interfaces;
using DesignPatterns.Library.FactoryMethod.Models;

namespace DesignPatterns.Library.FactoryMethod
{
    public class TableCreator : Creator
    {
        public override IFurniture CreateFurniture(string model, decimal price)
        {
            return new Table()
            {
                Model = model,
                Price = price,
            };
        }
    }
}
