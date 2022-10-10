using TicketSystemClassLibrary;

namespace Oresundsbron
{
    public class OCar : Car
    {
        public OCar(string licenseplate) : base(licenseplate)
        {

        }
        /// <summary>
        /// Method for getting the price it costs to pass bridge
        /// </summary>
        /// <returns>returns either 161 if there is Brobizz, 410 if not</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 161;
            }
            else
            {
                return 410;
            }
        }
        /// <summary>
        /// Method for getting the vehicletype as string
        /// </summary>
        /// <returns>returns "Oresund car" no matter what</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}