using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Client starts...");
            ClientMethod(creator);
            Console.WriteLine("Client finish!\n");
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
