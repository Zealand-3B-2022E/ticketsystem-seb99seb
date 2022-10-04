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
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Method to return double - set to 125
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 125;
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
