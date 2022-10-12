namespace DesignPatterns.Library.Builder.Models
{
    /// <summary>
    /// Двигун автомобіля
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Назва моделі
        /// </summary>
        public string Model { get; set; } = "";

        /// <summary>
        /// Потужність двигуна
        /// </summary>
        public double Power { get; set; }

        /// <summary>
        /// Максимальна швидкість двигуна
        /// </summary>
        public double MaxSpeed { get; set; }

        /// <summary>
        /// Вага двигуна
        /// </summary>
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"Engine: {Model} {Power}hp, {MaxSpeed}km, {Weight}kg";
        }
    }
}
