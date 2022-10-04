namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Public class Car
    /// Contains properties string LicensePlate and DateTime Date,
    /// and methods Price() and VehicleType().
    /// </summary>
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Method to return double - set to 240
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Method to return string "Car"
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}