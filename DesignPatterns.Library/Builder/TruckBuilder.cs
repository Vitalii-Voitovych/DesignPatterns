using DesignPatterns.Library.Builder.Models;

namespace DesignPatterns.Library.Builder
{
    public class TruckBuilder
    {
        private Truck truck;

        public TruckBuilder()
        {
            truck = new Truck();
        }

        public TruckBuilder SetModelName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Назва моделі не може бути null або пробіл");
            }
            truck.Model = name;
            return this;
        }

        public TruckBuilder SetBody(Body body)
        {
            truck.Body = body ?? throw new ArgumentNullException(nameof(body), "Не можна зробити машину без корпусу");
            return this;
        }

        public TruckBuilder SetEngine(Engine engine)
        {
            truck.Engine = engine ?? throw new ArgumentNullException(nameof(engine), "Не можна зробити машину без двигуна");
            return this;
        }

        public TruckBuilder SetTank(Tank tank)
        {
            truck.Tank = tank ?? throw new ArgumentNullException(nameof(tank), "Не можна зробити машину без паливного");
            return this;
        }

        public Truck CreateTruck() => truck;
    }
}
