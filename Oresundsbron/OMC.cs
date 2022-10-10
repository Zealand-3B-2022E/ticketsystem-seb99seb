using TicketSystemClassLibrary;

namespace Oresundsbron
{
    public class OMC : MC
    {
        public OMC(string licenseplate) : base(licenseplate)
        {

        }
        /// <summary>
        /// Method for getting the price it costs to pass bridge
        /// </summary>
        /// <returns>returns either 73 if there is Brobizz, 210 if not</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 73;
            }
            else
            {
                return 210;
            }
        }
        /// <summary>
        /// Method for getting the vehicletype as string
        /// </summary>
        /// <returns>returns "Oresund MC" no matter what</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}