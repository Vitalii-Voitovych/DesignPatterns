namespace DesignPatterns.Library.FactoryMethod
{
    public class FactoryMethodClient
    {
        private Creator creator;

        public FactoryMethodClient(Creator creator)
        {
            this.creator = creator;
        }

        public void Main()
        {
            Console.WriteLine("FactoryMethodClient starts...");
            ClientMethod(creator);
            Console.WriteLine("FactoryMethodClient finish!\n");
        }
        
        public void ClientMethod(Creator creator)
        {
            Console.WriteLine($"{creator.GetType().Name} starts...\n");

            var furniture = creator.CreateFurniture("X1", 33);
            furniture.PrintInfo();

            Console.WriteLine($"\n{creator.GetType().Name} finish.");
        }
    }
}
