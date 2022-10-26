using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// public class for inheritence
    /// </summary>
    public class Vehicle
    {
        public string LicensePlate { set; get; }
        public DateTime Date { get; set; }
        public bool Brobizz { get; set; }
        public Vehicle(string licensePlate)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException();
            }
            else
            {
               LicensePlate = licensePlate;
            }
        }
        /// <summary>
        /// Method to return Price as double
        /// </summary>
        /// <returns></returns>
        public virtual double Price()
        {
            return 0;
        }
        /// <summary>
        /// Method to return car as string
        /// </summary>
        /// <returns></returns>
        public virtual string VehicleType()
        {
            return "vehicle";
        }
    }
}
