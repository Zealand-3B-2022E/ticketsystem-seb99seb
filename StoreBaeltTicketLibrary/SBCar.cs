using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class SBCar : Car
    {
        /// <summary>
        /// New bool property, used to detertime whether or not to give 20% discount
        /// </summary>
        public bool Weekend { get; set; }
        public SBCar(string licenseplate):base(licenseplate)
        {

        }
        /// <summary>
        /// Price method that returns double 240 by default, can however get discount by both or Weekend discount and Brobizz
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double tempvar = 240;
            if (Weekend)
            {
                tempvar -= (tempvar * 0.2);
            }
            if (Brobizz)
            {
                tempvar -= (tempvar * 0.05);
            }
            return tempvar;
        }

    }
}