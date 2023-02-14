using CalculoCDB.API.Application;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CDBController : ControllerBase
    {
        private readonly CDBService _cdbService;

        public CDBController(CDBService cdbService)
        {
            _cdbService = cdbService;
        }

        [HttpGet]
        public ActionResult<decimal> CalculateCDB(double VI, int months)
        {
            double result = _cdbService.CalculateCDB(VI, months);
            return Ok(result);
        }
    }
}
