using DesignPatterns.Library.FactoryMethod.Interfaces;

namespace DesignPatterns.Library.FactoryMethod.Models
{
    public class Chair : IFurniture
    {
        private string model = "";
        public string Model 
        { 
            get => model;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Не може бути пустим або null");
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
                    throw new ArgumentException("Ціна не може бути меншою за нуль", nameof(value));
                }
                price = value;
            }  
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Chair info: {Model} ${Price}");
        }

        public override string ToString()
        {
            return $"Chair info: {Model} ${Price}";
        }
    }
}
