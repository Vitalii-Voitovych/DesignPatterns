using DesignPatterns.Library.AbstractFactory;
using DesignPatterns.Library.AbstractFactory.Models;

namespace DesignPatterns.Tests.CreationalPatterns
{
    [TestClass()]
    public class AbstractFactoryTests
    {
        [TestMethod()]
        public void ModernFactoryTest()
        {
            //Arrange
            var factory = new ModernFurnitureFactory();
            var chair1 = new ModernChair()
            {
                Model = "X1",
                Price = 32,
            };
            var table1 = new ModernTable()
            {
                Model = "X1",
                Price = 40,
            };

            //Act
            var chair2 = factory.CreateChair("X1", 32);
            var table2 = factory.CreateTable("X1", 40);

            //Assert
            Assert.AreEqual(chair1.ToString(), chair2.ToString());
            Assert.AreEqual(table1.ToString(), table2.ToString());
        }

        [TestMethod()]
        public void VictorianFactoryTest()
        {
            //Arrange
            var factory = new VictorianFurnitureFactory();
            var chair1 = new VictorianChair()
            {
                Model = "X1",
                Price = 32,
            };
            var table1 = new VictorianTable()
            {
                Model = "X1",
                Price = 40,
            };

            //Act
            var chair2 = factory.CreateChair("X1", 32);
            var table2 = factory.CreateTable("X1", 40);

            //Assert
            Assert.AreEqual(chair1.ToString(), chair2.ToString());
            Assert.AreEqual(table1.ToString(), table2.ToString());
        }
    }
}
