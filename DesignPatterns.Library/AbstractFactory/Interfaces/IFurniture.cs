using DesignPatterns.Library.AbstractFactory.Models;

namespace DesignPatterns.Library.AbstractFactory.Interfaces
{
    public interface IFurniture
    {
        FurnitureStyle Style { get; }
        string Model { get; set; }
        decimal Price { get; set; }
    }
}
