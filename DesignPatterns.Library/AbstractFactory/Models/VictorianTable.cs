using DesignPatterns.Library.AbstractFactory.Interfaces;

namespace DesignPatterns.Library.AbstractFactory.Models
{
    public class VictorianTable : ITable
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

        public void Stay()
        {
            Console.WriteLine("The table stays");
        }

        public override string ToString()
        {
            return $"Table: {Style} {Model} ${Price}";
        }
    }
}
