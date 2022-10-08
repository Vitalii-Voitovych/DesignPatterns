using DesignPatterns.Library.FactoryMethod.Interfaces;
using DesignPatterns.Library.FactoryMethod.Models;

namespace DesignPatterns.Library.FactoryMethod
{
    public class ChairCreator : Creator
    {
        public override IFurniture CreateFurniture(string model, decimal price)
        {
            return new Chair()
            {
                Model = model,
                Price = price,
            };
        }
    }
}
