using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class SBVehicle : Vehicle
    {
        /// <summary>
        /// bool property, used to detertime whether or not to give 20% discount
        /// </summary>
        public bool Weekend { get; set; }
        public SBVehicle(string licensePlate) : base(licensePlate)
        {
        }

    }
}
