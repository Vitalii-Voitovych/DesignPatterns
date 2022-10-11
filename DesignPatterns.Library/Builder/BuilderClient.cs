using DesignPatterns.Library.Builder.Models;

namespace DesignPatterns.Library.Builder
{
    public class BuilderClient
    {
        public void Main()
        {
            Console.WriteLine("BuilderClient starts...\n");

            Console.WriteLine("Create car1");
            CarBuilder carBuilder1 = new CarBuilder();
            carBuilder1.SetModelName("Tiger");
            carBuilder1.SetBody(new Body() { Model = "X23", Weight = 230 });
            carBuilder1.SetEngine(new Engine() { Model = "x323", MaxSpeed = 120, Weight = 75, Power = 38 });
            carBuilder1.SetTank(new Tank() { MaxVolume = 45, Model = "x122", Weight = 4 });
            Car car1 = carBuilder1.CreateCar();
            Console.WriteLine(car1 + "\n");

            Console.WriteLine("Create car1");
            Truck truck = new TruckBuilder()
                .SetModelName("Tiger")
                .SetBody(new Body() { Model = "X23", Weight = 230 })
                .SetEngine(new Engine() { Model = "x323", MaxSpeed = 120, Weight = 75, Power = 38 })
                .SetTank(new Tank() { MaxVolume = 45, Model = "x122", Weight = 4 })
                .CreateTruck();
            Console.WriteLine(truck + "\n");

            Console.WriteLine("BuilderClient finish.");
        }

    }
}
