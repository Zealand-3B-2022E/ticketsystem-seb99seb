using StoreBaeltTicketLibrary;
using TicketSystemClassLibrary;

namespace Storebæltsbroen_API.Managers
{
    public class TicketsManager
    {
        private static List<SBVehicle> _tickets = new List<SBVehicle>()
        {
            new SBCar("JHF84N9"){Weekend=true, Brobizz=true},
            new SBCar("2KJGB23"),
            new SBCar("2KJGB23"){Brobizz=true},
            new SBCar("SDNKB65"){Weekend=true},
            new SBMC("SFBN563"){Brobizz=true},
            new SBMC("DFI4444"),
            new SBMC("25YBDSF")
        };
        public SBCar CreateCar(SBCar car)
        {
            _tickets.Add(car);
            return car;
        }
        public SBMC CreateMC(SBMC MC)
        {
            _tickets.Add(MC);
            return MC;
        }
        public List<SBVehicle> GetList()
        {
            return _tickets;
        }
        public List<SBVehicle> GetAllByLicenseplate(string licenseplate)
        {
            List<SBVehicle> dummylist = new List<SBVehicle>();
            foreach (SBVehicle vehicle in _tickets)
            {
                if (vehicle.LicensePlate == licenseplate)
                {
                    dummylist.Add(vehicle);
                }
            }
            if (dummylist.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return dummylist;
        }
    }
}
