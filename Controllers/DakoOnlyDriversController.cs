namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class DakoOnlyDriversController : Controller
{
    [HttpGet("accounts/{accountUid}/dakoOnlyDrivers")]
    [ProducesResponseType(typeof(IEnumerable<DakoOnlyDriver>), 200)]
    public ActionResult<IEnumerable<DakoOnlyDriver>> GetDakoOnlyDrivers(string accountUid)
    {
        return Ok();
    }
}