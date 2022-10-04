using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// publuc abstract class
    /// </summary>
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Method to return Price as double
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        /// <summary>
        /// Method to return car as string
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
    }
}
