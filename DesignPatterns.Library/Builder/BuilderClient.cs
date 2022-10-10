using DesignPatterns.Library.Builder.Models;

namespace DesignPatterns.Library.Builder
{
    public class BuilderClient
    {
        public void Main()
        {
            Console.WriteLine("BuilderClient starts...\n");

            Console.WriteLine("Create car1");
            CarBuilder carBuilder = new CarBuilder();
            carBuilder.SetModelName("Tiger");
            carBuilder.SetBody(new Body() { Model = "X23", Weight = 230 });
            carBuilder.SetEngine(new Engine() { Model = "x323", MaxSpeed = 120, Weight = 75, Power = 38 });
            carBuilder.SetTank(new Tank() { MaxVolume = 45, Model = "x122", Weight = 4 });
            Car car = carBuilder.CreateCar();
            Console.WriteLine(car + "\n");

            Console.WriteLine("BuilderClient finish.");
        }

    }
}
