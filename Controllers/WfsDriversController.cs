namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsDriversController : Controller
{
    [HttpGet("accounts/{accountUid}/wfsDrivers")]
    public ActionResult<IEnumerable<string>> ReadWfsDrivers(string accountUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsDrivers")]
    public ActionResult<WfsDriver> CreateOrUpdateWfsDriver(string accountUid, [FromBody] WfsDriver wfsDriver)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsDrivers/{driverUid}")]
    public ActionResult<Account> ReadWfsDriver(string accountUid, string driverUid)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}/wfsDrivers/{driverUid}")]
     public ActionResult DeleteWfsDriver(string accountUid, string driverUid)
    {
        return NoContent();
    }
}
