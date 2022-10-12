using DesignPatterns.Library.FactoryMethod;
using DesignPatterns.Library.FactoryMethod.Models;

namespace DesignPatterns.Tests.CreationalPatterns
{
    [TestClass()]
    public class FactoryMethodTests
    {
        [TestMethod()]
        public void ChairFactoryMethodTest()
        {
            //Arrange
            var creator = new ChairCreator();
            var chair1 = new Chair()
            {
                Model = "X1",
                Price = 32,
            };

            //Act
            var chair2 = creator.CreateFurniture("X1", 32);

            //Assert
            Assert.AreEqual(chair1.ToString(), chair2.ToString());
        }

        [TestMethod()]
        public void TableFactoryMethodTest()
        {
            //Arrange
            var creator = new TableCreator();
            var table1 = new Table()
            {
                Model = "X1",
                Price = 40,
            };

            //Act
            var table2 = creator.CreateFurniture("X1", 40);

            //Assert
            Assert.AreEqual(table1.ToString(), table2.ToString());
        }
    }
}
