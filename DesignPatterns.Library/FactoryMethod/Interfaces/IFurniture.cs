namespace DesignPatterns.Library.FactoryMethod.Interfaces
{
    public interface IFurniture
    {
        string Model { get; set; }
        decimal Price { get; set; }

        void PrintInfo();
    }
}
