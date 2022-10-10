namespace DesignPatterns.Library.Builder.Models
{
    /// <summary>
    /// Паливний бак
    /// </summary>
    public class Tank
    {
        /// <summary>
        /// Назва моделі
        /// </summary>
        public string Model { get; set; } = "";

        /// <summary>
        /// Максимальний об'єм баку
        /// </summary>
        public double MaxVolume { get; set; }

        /// <summary>
        /// Вага баку
        /// </summary>
        public double Weight { get; set; }
    }
}
