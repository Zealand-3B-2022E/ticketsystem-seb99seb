using Microsoft.AspNetCore.Mvc;
using Storebæltsbroen_API.Managers;
using StoreBaeltTicketLibrary;
using TicketSystemClassLibrary;

namespace Storebæltsbroen_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        private TicketsManager tm = new TicketsManager();
        [HttpGet]
        public IEnumerable<SBVehicle> GetList()
        {
            return tm.GetList();
        }
        [HttpGet]
        [Route("licenseplates/{licenseplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string licenseplate)
        {
            try
            {
                return Ok(tm.GetAllByLicenseplate(licenseplate));
            }
            catch (InvalidOperationException ioe)
            {
                return NotFound(ioe.Message);
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status304NotModified)]
        [Route("cars")]
        public IActionResult Post([FromBody] SBCar car)
        {
            try
            {
                return Ok(tm.CreateCar(car));
            }
            catch (ArgumentException ae)
            {
                return NotFound(ae.Message);
            }
        }
        [HttpPost]
        [Route("MCs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status304NotModified)]
        public IActionResult Post([FromBody] SBMC MC)
        {
            try
            {
                return Ok(tm.CreateMC(MC));
            }
            catch (ArgumentException ae)
            {
                return NotFound(ae.Message);
            }
        }
    }
}