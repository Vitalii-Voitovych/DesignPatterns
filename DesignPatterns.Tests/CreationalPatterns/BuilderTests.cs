using DesignPatterns.Library.Builder;
using DesignPatterns.Library.Builder.Models;

namespace DesignPatterns.Tests.CreationalPatterns
{
    [TestClass()]
    public class BuilderTests
    {

        [TestMethod()]
        public void CarBuilderTest()
        {
            //Arrange
            var carBuilder = new CarBuilder();
            carBuilder.SetModelName("VW Polo");
            carBuilder.SetEngine(new Engine() { Model = "VW X1", MaxSpeed = 220, Power = 34, Weight = 75 });
            carBuilder.SetBody(new Body() { Model = "VW Polo 1", Weight = 348 });
            carBuilder.SetTank(new Tank() { Model = "VW", MaxVolume = 45, Weight = 3 });

            var car1 = new Car()
            {
                Model = "VW Polo",
                Engine = new Engine() { Model = "VW X1", MaxSpeed = 220, Power = 34, Weight = 75 },
                Body = new Body() { Model = "VW Polo 1", Weight = 348 },
                Tank = new Tank() { Model = "VW", MaxVolume = 45, Weight = 3 },
            };

            //Act
            var car2 = carBuilder.CreateCar();

            //Assert
            Assert.AreEqual(car2.ToString(), car1.ToString());
        }

        [TestMethod]
        public void TruckBuilderTest()
        {
            //Arrange
            var truckBuilder = new TruckBuilder()
                .SetModelName("DAF X5")
                .SetEngine(new Engine() { Model = "DAF E2", Power = 342, MaxSpeed = 100, Weight = 120 })
                .SetBody(new Body() { Model = "DAF X5 v1", Weight = 232 })
                .SetTank(new Tank() { Model = "DAF TH1", MaxVolume = 120, Weight = 10 });

            var truck1 = new Truck()
            {
                Model = "DAF X5",
                Engine = new Engine() { Model = "DAF E2", Power = 342, MaxSpeed = 100, Weight = 120 },
                Body = new Body() { Model = "DAF X5 v1", Weight = 232 },
                Tank = new Tank() { Model = "DAF TH1", MaxVolume = 120, Weight = 10 },
            };

            //Act
            var truck2 = truckBuilder.CreateTruck();

            //Assert
            Assert.AreEqual(truck1.ToString(), truck2.ToString());
        }
    }
}
