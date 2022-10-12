namespace DesignPatterns.Library.Builder.Models
{
    /// <summary>
    /// Автомобіль
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Назва моделі
        /// </summary>
        public string Model { get; set; } = "";
        
        /// <summary>
        /// Двигун автомобіля
        /// </summary>
        public Engine? Engine { get; set; }

        /// <summary>
        /// Корпус автомобіля
        /// </summary>
        public Body? Body { get; set; }

        /// <summary>
        /// Паливний бак автомобіля
        /// </summary>
        public Tank? Tank { get; set; }

        /// <summary>
        /// Вага автомобіля
        /// </summary>
        public double? Weight => Engine?.Weight + Body?.Weight + Tank?.Weight;

        public override string ToString()
        {
            return $"Car: {Model}\n {Engine}\n {Body}\n {Tank}\n Weight = {Weight}kg";
        }
    }
}
