using DesignPatterns.Library.AbstractFactory.Interfaces;

namespace DesignPatterns.Library.AbstractFactory.Models
{
    public class VictorianChair : IChair
    {
        private string model = "";
        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Значення не може бути null, або містити пробіл");
                }
                model = value;
            }
        }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна не може бути менше нуля", nameof(value));
                }
                price = value;
            }
        }

        public FurnitureStyle Style => FurnitureStyle.Victorian;

        public void SitOn()
        {
            Console.WriteLine("Someone sits on the chair");
        }

        public override string ToString()
        {
            return $"Chair: {Style} {Model} ${Price}";
        }
    }
}
