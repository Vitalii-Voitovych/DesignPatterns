using DesignPatterns.Library.Builder.Interfaces;
using DesignPatterns.Library.Builder.Models;

namespace DesignPatterns.Library.Builder
{
    public class CarBuilder : IVehicleBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public void Reset()
        {
            car = new Car();
        }

        public void SetModelName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Назва моделі не може бути null або пробіл");
            }
            car.Model = name;
        }

        public void SetBody(Body body)
        {
            car.Body = body ?? throw new ArgumentNullException(nameof(body), "Не можна зробити машину без корпусу");
        }

        public void SetEngine(Engine engine)
        {
            car.Engine = engine ?? throw new ArgumentNullException(nameof(engine), "Не можна зробити машину без двигуна");
        }

        public void SetTank(Tank tank)
        {
            car.Tank = tank ?? throw new ArgumentNullException(nameof(tank), "Не можна зробити машину без паливного");
        }

        public Car CreateCar() => car;
    }
}
