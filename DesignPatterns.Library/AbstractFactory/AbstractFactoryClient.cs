namespace DesignPatterns.Library.AbstractFactory
{
    public class AbstractFactoryClient
    {
        private IFurnitureFactory factory;

        public AbstractFactoryClient(IFurnitureFactory factory)
        {
            this.factory = factory;
        }

        public void Main()
        {
            Console.WriteLine("Client starts...");
            ClientMethod(factory);
            Console.WriteLine("Client finish!\n");
        }

        private void ClientMethod(IFurnitureFactory factory)
        {
            Console.WriteLine($"{factory.GetType().Name} starts...\n");

            var chair = factory.CreateChair("X1", 23);
            var table = factory.CreateTable("X1", 32);

            Console.WriteLine(chair);
            chair.SitOn();
            Console.WriteLine();

            Console.WriteLine(table);
            table.Stay();
            Console.WriteLine();

            Console.WriteLine($"{factory.GetType().Name} finish.");
        }
    }
}
