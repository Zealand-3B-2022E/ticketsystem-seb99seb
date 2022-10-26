using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class SBMC : SBVehicle
    {
        public SBMC(string licenseplate) : base(licenseplate)
        {
            Weekend = SetWeekendFalse();
        }
        private bool SetWeekendFalse()
        {
            return Weekend = false;
        }
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
    }
}
