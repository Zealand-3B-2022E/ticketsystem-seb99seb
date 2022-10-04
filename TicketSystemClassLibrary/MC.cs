using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Public class MC using abstract class "Vehicle"
    /// Contains properties string LicensePlate and DateTime Date,
    /// and methods Price() and VehicleType().
    /// </summary>
    public class MC : Vehicle
    {
        public MC(string licensePlate):base(licensePlate)
        {

        }
        /// <summary>
        /// Method to return double - set to 125, can however get a 5% discount
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 125 - (125 * 0.05);
            }
            else
            {
                return 125;
            }
        }
        /// <summary>
        /// Method to return string "MC"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
