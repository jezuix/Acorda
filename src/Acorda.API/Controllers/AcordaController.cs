using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Acorda.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcordaController : Controller
    {
        [HttpPost("Acorda/{macAddress}")]
        public async Task<IActionResult> Acorda(string macAddress)
        {
            try
            {
                await WOL.WakeOnLan(macAddress);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
