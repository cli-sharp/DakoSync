namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsDriversController : Controller
{
    [HttpGet("accounts/{accountUid}/wfsDrivers")]
    [ProducesResponseType(typeof(IEnumerable<string>), 200)]
    public ActionResult<IEnumerable<string>> ReadWfsDrivers(string accountUid)
    {
        return Ok();
    }

    [HttpPost("accounts/{accountUid}/wfsDrivers")]
    [ProducesResponseType(typeof(WfsDriver), 201)]
    public ActionResult<WfsDriver> CreateWfsDriver(string accountUid, [FromBody] WfsDriver wfsDriver)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}/wfsDrivers/{driverUid}")]
    [ProducesResponseType(typeof(WfsDriver), 200)]
    public ActionResult<WfsDriver> ReadWfsDriver(string accountUid, string driverUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}/wfsDrivers/{driverUid}")]
    [ProducesResponseType(typeof(WfsDriver), 200)]
    public ActionResult<WfsDriver> UpdateWfsDriver(
        string accountUid, string driverUid, [FromBody] WfsDriver wfsDriver)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}/wfsDrivers/{driverUid}")]
    [ProducesResponseType(204)]
     public ActionResult DeleteWfsDriver(string accountUid, string driverUid)
    {
        return NoContent();
    }
}
