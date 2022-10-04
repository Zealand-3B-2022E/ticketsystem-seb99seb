namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Public class Car using abstract class "Vehicle"
    /// Contains properties string LicensePlate and DateTime Date,
    /// and methods Price() and VehicleType().
    /// </summary>
    public class Car : Vehicle
    {
        public Car(string licensePlate) :base(licensePlate)
        {

        }
        /// <summary>
        /// Method to return double - set to 240
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// Method to return string "Car"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}