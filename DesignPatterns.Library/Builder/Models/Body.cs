namespace DesignPatterns.Library.Builder.Models
{
    /// <summary>
    /// Корпус автомобіля
    /// </summary>
    public class Body
    {
        /// <summary>
        /// Назва моделі
        /// </summary>
        public string Model { get; set; } = "";

        /// <summary>
        /// Вага корпусу
        /// </summary>
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"Body: {Model} {Weight}kg";
        }
    }
}
