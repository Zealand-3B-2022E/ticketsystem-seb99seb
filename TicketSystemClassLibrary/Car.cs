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
        /// Method to return double - set to 240, can however get a 5% discount
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 240 - (240*0.05);
            }
            else
            {
                return 240;
            }
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