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
        private string _licensePlate;
        public DateTime Date { get; set; }
        public bool Brobizz { get; set; }
        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
        }
        /// <summary>
        /// Property that makes sure licenseplate isn't longer than 7 symbols
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length <= 7)
                {
                    _licensePlate = value;
                }
                else
                {
                    throw new ArgumentException();
                }
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
